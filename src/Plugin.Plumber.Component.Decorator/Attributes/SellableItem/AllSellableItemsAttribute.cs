﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.Plumber.Component.Decorator.Attributes.SellableItem
{
    /// <summary>
    ///     Attribute to indicate the component to which the attribute is attached should 
    ///     be added to all sellable items.
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AllSellableItemsAttribute : SellableItemAttributeBase
    {
        public AllSellableItemsAttribute(AddToSellableItem addToSellableItem = AddToSellableItem.SellableItemAndVariant) : base(addToSellableItem)
        {
        }
    }
}
