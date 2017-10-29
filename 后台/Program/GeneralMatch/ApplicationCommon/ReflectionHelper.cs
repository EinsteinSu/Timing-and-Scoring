using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;

namespace ApplicationCommon
{
    public static class ReflectionHelper
    {
        //通过 DataRow 反射实体属性
        public static object ReflectionFromDataRow(DataRow dr, Type objType)
        {
            object obj = System.Activator.CreateInstance(objType);
            foreach (DataColumn dc in dr.Table.Columns)
            {
                Type ret = objType;
                PropertyInfo pr = ret.GetProperty(dc.ColumnName.ToString().ToUpper());
                if (pr != null)
                    SetProperty(pr, obj, dr[dc.ColumnName]);
            }
            return obj;
        }

        //通过 属性 反射DataRow
        public static void SetDataRowFromProperty(DataRow dr, object obj)
        {
            foreach (DataColumn dc in dr.Table.Columns)
            {
                dr[dc.ColumnName] = GetObjectProperty(dc.ColumnName.ToUpper(), obj);
            }
        }

        #region Reflection method
        public static object ReflectionMethod(bool bInitalize, string filePath, string dllName, string moduleName, string methodName, params object[] objs)
        {
            Assembly ass = Assembly.LoadFile(String.Format(@"{0}\{1}", filePath, dllName));
            Type t = ass.GetType(moduleName);
            MethodInfo info = t.GetMethod(methodName);
            if (bInitalize)
                return info.Invoke(ReflectionObjectByName(filePath, dllName, moduleName), objs);
            else
                return info.Invoke(ReflectionObjectByName(filePath, dllName, moduleName), objs);
        }


        public static object ReflectionMethodByRun(bool bInitalize, string dllName, string moduleName, string methodName, params object[] objs)
        {
            return ReflectionMethod(bInitalize, DirectoryHelper.RunDirectory, dllName, moduleName, methodName, objs);
        }
        #endregion

        public static Type GetObjectTypeByName(string filePath, String dllName, String moduleName)
        {
            Assembly assembly = Assembly.LoadFile(String.Format(@"{0}\{1}", filePath, dllName));
            Type type = assembly.GetType(moduleName);
            return type;
        }

        public static Type GetObjectTypeByName(string dllName, string moduleName)
        {
            return GetObjectTypeByName(DirectoryHelper.RunDirectory, dllName, moduleName);
        }

        public static object ReflectionObjectByName(string filePath, String dllName, String moduleName)
        {
            return Activator.CreateInstance(GetObjectTypeByName(filePath,dllName,moduleName));
        }

        public static object ReflectionObjectByName(string dllName, string moduleName)
        {
            return ReflectionObjectByName(DirectoryHelper.RunDirectory, dllName, moduleName);
        }

        public static object GetObjectProperty(string property, object obj)
        {
            Type t = obj.GetType();
            PropertyInfo p = t.GetProperty(property);
            return p.GetValue(obj, null);
        }

        public static string GetGuid(object obj)
        {
            try
            {
                string guid = GetObjectProperty("GUID", obj).ToString();
                if (guid.Length == 0)
                    return "Unknown";
                else
                    return guid;
            }
            catch
            {
                return "Unknown";
            }
        }

        //反射属性
        public static void SetProperty(PropertyInfo pr, object obj, object Value)
        {
            switch (pr.PropertyType.Name)
            {
                case "Int32":
                    try
                    {
                        pr.SetValue(obj, int.Parse(Value.ToString()), null);
                    }
                    catch
                    {
                        pr.SetValue(obj, 0, null);
                    }
                    break;
                case "String":
                    pr.SetValue(obj, Value.ToString().Replace("'", "''"), null);
                    break;
                case "DateTime":
                    try
                    {
                        pr.SetValue(obj, DateTime.Parse(Value.ToString()), null);
                    }
                    catch
                    {
                        pr.SetValue(obj, DateTime.Now, null);
                    }
                    break;
                case "Double":
                    try
                    {
                        pr.SetValue(obj, double.Parse(Value.ToString()), null);
                    }
                    catch
                    {
                        pr.SetValue(obj, 0.0, null);
                    }
                    break;
                case "Byte[]":
                    try
                    {
                        pr.SetValue(obj, Value, null);
                    }
                    catch
                    {
                        Byte[] bt = new Byte[0];
                        pr.SetValue(obj, bt, null);
                    }
                    break;

            }
        }

        //获取所有枚举类型
        public static List<string> GetEnums(Type t)
        {
            List<string> lst = new List<string>();
            foreach (object obj in System.Enum.GetValues(t))
            {
                lst.Add(obj.ToString());
            }
            return lst;
        }
    }
}
