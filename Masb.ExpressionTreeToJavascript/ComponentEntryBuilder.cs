﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq.Expressions;

namespace Masb.ExpressionTreeToJavascript
{
    public abstract class ComponentEntryBuilder
    {
    	// cannot derive this class from outside: constructor is private
        private ComponentEntryBuilder()
        {
        }
    
        private static ComponentEntryBuilder CreateBuilder(Type type)
        {
    		// Activator.CreateInstance without parameters is very fast
    		// MakeGenericType is also very fast
            return (ComponentEntryBuilder)Activator.CreateInstance(
    			typeof(Generic<>)
    				.MakeGenericType(type));
        }
    
        protected abstract ComponentEntry Create(object value);
    
        public static ComponentEntry Create(Type type, object value)
        {
            var builder = CreateBuilder(type);
            return builder.Create(value);
        }
        protected abstract ComponentEntry Create(Delegate getter);
    
        public static ComponentEntry Create(Type type, Delegate getter)
        {
            var builder = CreateBuilder(type);
            return builder.Create(getter);
        }
        protected abstract ComponentEntry Create(Expression expression);
    
        public static ComponentEntry Create(Type type, Expression expression)
        {
            var builder = CreateBuilder(type);
            return builder.Create(expression);
        }
    
        private class Generic<T> : ComponentEntryBuilder
        {
            protected override ComponentEntry Create(object value)
            {
                return new ComponentEntry<T>(
    				(Option<T>)(T)value);
            }
            protected override ComponentEntry Create(Delegate getter)
            {
                return new ComponentEntry<T>(
    				(Func<T>)getter);
            }
            protected override ComponentEntry Create(Expression expression)
            {
                return new ComponentEntry<T>(
    				(Expression<Func<T>>)expression);
            }
        }
    }
}
