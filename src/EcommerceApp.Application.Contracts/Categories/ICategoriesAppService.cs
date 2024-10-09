﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EcommerceApp.Categories
{
    // الطريقه basic
    public interface ICategoriesAppService : ICrudAppService
        <CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
    {
    }
}
