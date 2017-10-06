﻿using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using NetOffice;

namespace IExcelApi.Utils
{
    public class ProjectInfo : IFactoryInfo
    {
        #region Fields

        private string _namespace = "NetOffice.IExcelApi";
        private Guid[] _componentGuid = new Guid[] { new Guid("00020813-0000-0000-C000-000000000046") };
        private Assembly _assembly;
        private Type[] _exportedTypes;
        private string[] _dependents;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

        public bool Contains(Type type)
        {
            if (null == _exportedTypes)
                _exportedTypes = Assembly.GetExportedTypes();

            foreach (Type item in _exportedTypes)
            {
                if (item == type)
                    return true;
            }

            return false;
        }

        public bool Contains(string className)
        {
            if (null == _exportedTypes)
                _exportedTypes = Assembly.GetExportedTypes();

            foreach (Type item in _exportedTypes)
            {
                if (item.Name.EndsWith(className, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }

            return false;
        }

        public string AssemblyNamespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid[] ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        public string[] Dependencies
        {
            get
            {
                if (null == _dependents)
                    _dependents = new string[] { "IOfficeApi.dll", "IVBIDEApi.dll" };
                return _dependents;
            }
        }

        public bool IsDuck
        {
            get
            {
                return true;
            }
        }

        #endregion
    }
}