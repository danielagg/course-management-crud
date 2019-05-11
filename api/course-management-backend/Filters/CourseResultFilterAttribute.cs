using AutoMapper;
using course_management_backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course_management_backend.Filters
{
    public class CourseResultFilterAttribute : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context,
            ResultExecutionDelegate next)
        {
            var resultFromAction = context.Result as ObjectResult;

            // just continue
            if(resultFromAction?.Value == null ||
                resultFromAction.StatusCode < 200 ||
                resultFromAction.StatusCode >= 300)
            {
                await next();
                return;
            }
            else
            {
                resultFromAction.Value = Mapper.Map<CourseModel>(resultFromAction.Value);
            }

            await next();
        }
    }
}
