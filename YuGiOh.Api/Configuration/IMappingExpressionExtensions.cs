using AutoMapper;
using System;
using System.Linq.Expressions;

namespace YuGiOh.Api.Configuration
{
    public static class IMappingExpressionExtensions
    {
        public static IMappingExpression<TSource, TDestination> Ignore<TSource, TDestination>(
            this IMappingExpression<TSource, TDestination> map,
            Expression<Func<TDestination, object>> selector)
        {
            map.ForMember(selector, config => config.Ignore());
            return map;
        }
    }
}
