using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ServiceLayer.Models;
using System.Data.Entity;
using DataAccessLayer.Entities;

namespace ServiceLayer
{
    public class TigerManager
    {
        public TigerManager() {
            
        }

        public TigerModel GetTiger(Guid id) {

            using (var context = new TigerContext()) {
                var entity = context.Tigers.Single(x => x.Id == id); //Vad händer om vi inte hittar någon tiger?
                var nests = entity.Nests.ToList();
                var model = new TigerModel
                {
                    Id = entity.Id,
                    Color = entity.Color,
                    Weight = entity.Weight,
                    Nests = nests.Select(x => new NestModel
                    {
                        Id = x.Id,
                        Type = x.Type,
                        FirstChoice = x.FirstChoice,
                        Value = x.Id,
                        Text = x.Type.ToString()
                    }).ToList()
                };
                return model;
            }
             
        }

        public void CreateTiger(TigerModel model)
        {
            using (var context = new TigerContext()) {
                var entity = new Tiger
                {
                    Id = Guid.NewGuid(),
                    Color = model.Color,
                    Weight = model.Weight
                };
                context.Tigers.Add(entity);
                context.SaveChanges();
            }
                
        }

        public List<TigerModel> GetAllTigers()
        {
            using (var context = new TigerContext())
            {
                var entities = context.Tigers.ToList();
                var models = context.Tigers.Select(entity => new TigerModel
                {
                    Id = entity.Id,
                    Color = entity.Color,
                    Weight = entity.Weight
                }).ToList();

                return models;
            }

            
            
        }
    }
}
