using DL;
using System;
using System.Collections.Generic;

namespace SL
{
    class DataRepository : IDataRepository
    {
        private IDataContext _dataContext;

        public DataRepository(IDataContext data)
        {
            _dataContext = data;
        }

        public DataRepository()
        {
            _dataContext = new DataContext();
        }

        public void AddLocation(short id,string name, decimal costRate, decimal avaibility, DateTime modifiedDate)
        {
            if (id > 0 && !GetLocationsIds().Contains(id))
            {
                Location newLocation = new Location();
                newLocation.LocationID = id;
                newLocation.Name = name;
                newLocation.CostRate = costRate;
                newLocation.Availability = avaibility;
                newLocation.ModifiedDate = modifiedDate;
                _dataContext.Add(newLocation);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void DeleteLocation(short id)
        {
            if (id > 0 && GetLocationsIds().Contains(id))
            {
                Location deletingLocation = _dataContext.Get(id);
                _dataContext.Delete(deletingLocation);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public decimal GetLocationAvaibility(short id)
        {
            return _dataContext.Get(id).Availability;
        }

        public decimal GetLocationCostRate(short id)
        {
            return _dataContext.Get(id).CostRate;
        }

        public DateTime GetLocationModifiedDate(short id)
        {
            return _dataContext.Get(id).ModifiedDate;
        }

        public string GetLocationName(short id)
        {
            return _dataContext.Get(id).Name;
        }

        public List<short> GetLocationsIds()
        {
            List<short> result = new List<short>();
            foreach(Location location in _dataContext.GetAll())
            {
                result.Add(location.LocationID);
            }
            return result;
        }

        public void UpdateLocation(short id, string name, decimal costRate, decimal avaibility, DateTime modifiedDate)
        {
            Location location = new Location();
            location.LocationID = id;
            location.Name = name;
            location.CostRate = costRate;
            location.Availability = avaibility;
            location.ModifiedDate = modifiedDate;
            _dataContext.Update(id, location);
        }
    }
}