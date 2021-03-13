using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ServiceLayer.Models;

namespace ServiceLayer
{
    public class TigerManager
    {
        private TigerContext _context;
        public TigerManager() {
            _context = new TigerContext();
        }

        public TigerModel GetTiger(Guid id) {
            var entity = _context.Tigers.Single(x => x.Id == id); //Vad händer om vi inte hittar någon tiger?
            var model = new TigerModel
            {
                Id = entity.Id,
                Color = entity.Color,
                Weight = entity.Weight
            };

            return model;
        }

        public void CreateTiger(TigerModel model)
        {
        }

        public List<TigerModel> GetAllTigers()
        {
            var models = _context.Tigers.Select(entity => new TigerModel {
                Id = entity.Id,
                Color = entity.Color,
                Weight = entity.Weight
            }).ToList();

            return models;
            
        }
    }
}
