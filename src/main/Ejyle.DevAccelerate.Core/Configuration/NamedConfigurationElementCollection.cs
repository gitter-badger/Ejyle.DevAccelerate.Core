// ----------------------------------------------------------------------------------------------------------------------
// Copyright © Ejyle Technologies (P) Ltd (www.ejyle.com)
// Licensed under the MIT license. See the LICENSE file in the project's root directory for complete license information.
// ----------------------------------------------------------------------------------------------------------------------

using System.Configuration;

namespace Ejyle.DevAccelerate.Core.Configuration
{
    /// <summary>
    /// Represents the collection of <see cref="NamedConfigurationElement"/> objects.
    /// </summary>
    public abstract class NamedConfigurationElementCollection<T> : ConfigurationElementCollection
        where T : NamedConfigurationElement
    {
        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="NamedConfigurationElement"/> from the collection.
        /// </summary>
        /// <param name="index">
        /// The index of the <see cref="NamedConfigurationElement"/> within the collection.
        /// </param>
        /// <returns>Returns an instance of the <see cref="NamedConfigurationElement"/> class.</returns>
        public T this[int index]
        {
            get
            {
                return base.BaseGet(index) as T;
            }
            set
            {
                if (base.BaseGet(index) != null)
                {
                    base.BaseRemoveAt(index);
                }
                this.BaseAdd(index, value);
            }
        }

        public new T this[string name]
        {
            get
            {
                return base.BaseGet((object)name) as T;
            }
            set
            {
                if (base.BaseGet((object)name) != null)
                {
                    base.BaseRemove((object)name);
                }

                this.BaseAdd(value);
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Gets the name of the <see cref="NamedConfigurationElement"/> object as its key within the collection.
        /// </summary>
        /// <param name="element">
        /// The base class of the <see cref="NamedConfigurationElement"/> class.
        /// </param>
        /// <returns>
        /// Returns the name of the configuration element as an instance of <see cref="System.Object"/>.
        /// </returns>
        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((T)element).Name;
        }

        public T GetByName(string name)
        {
            return (T)this.BaseGet((object)name);
        }

        public void Add(T element)
        {
            this.BaseAdd(element);
        }

        public void Remove(string name)
        {
            this.BaseRemove((object)name);
        }

        public void RemoveAt(int index)
        {
            this.BaseRemoveAt(index);
        }

        #endregion Methods
    }
}
