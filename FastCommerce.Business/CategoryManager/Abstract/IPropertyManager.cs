﻿using FastCommerce.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FastCommerce.Business.CategoryManager.Abstract
{
    public interface IPropertyManager
    {

        Task<bool> AddProperty(Property property);
        Task<bool> AddProperties(List<Property> properties);
        Task<bool> DeleteProperty(Property property);
        Task<bool> UpdateProperty(Property property);
        Task<List<Property>> GetProperties();
        
        Task<List<Property>> GetPropertiesByCategoryId(int categoryId);
        Task<List<Property>> GetPropertiesByCategoryName(string categoryName);

        Task<Property> GetPropertyById(int Id);
    }
}
