﻿using System.Reflection;

namespace RepoDb
{
    /// <summary>
    /// A class used when extracting the class object properties and values.
    /// </summary>
    public class PropertyValue
    {
        /// <summary>
        /// Creates a new instance of <i>PropertyValue</i> class.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        /// <param name="value">The value of the property.</param>
        /// <param name="property">The actual property object.</param>
        public PropertyValue(string name, object value, PropertyInfo property)
        {
            Name = name;
            Value = value;
            Property = property;
        }

        /// <summary>
        /// Gets or sets the name of the property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Gets the actual property object.
        /// </summary>
        public PropertyInfo Property { get; }
    }
}
