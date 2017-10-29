using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ClientCommon
{
    public class TableSave
    {
        DataTable _dt;
        TableInfo _info;
        public TableSave(TableInfo info, DataTable dt)
        {
            _dt = dt;
            _info = info;
        }

        #region 新增 修改 删除操作
        public bool Insert(DataRow dr, out string errMsg)
        {
            errMsg = string.Empty;
            try
            {
                ISqlOperateLog info = (ISqlOperateLog)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, _info.InfoType);
                IDataCheck d = info as IDataCheck;
                info.OperateType = SystemOperateType.新增;
                if (d != null)
                {
                    if (!d.DataCheck(out errMsg))
                        return false;
                    else
                    {
                        try
                        {
                            InitializePst(info).Insert();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            errMsg += ex.Message;
                            return false;
                        }
                    }
                }
                else
                {
                    try
                    {
                        InitializePst(info).Insert();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        errMsg += ex.Message;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                errMsg += ex.Message;
                LogWrite.WriteErrorLogs(errMsg, ErrorLogType.Sql);
                return false;
            }
        }

        public bool InsertByImages(DataRow dr, out string errMsg, List<RemoteCommon.ImageSaveInfo> lst)
        {
            errMsg = string.Empty;
            try
            {
                ISqlOperateLog info = (ISqlOperateLog)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, _info.InfoType);
                IDataCheck d = info as IDataCheck;
                info.OperateType = SystemOperateType.新增;
                if (d != null)
                {
                    if (!d.DataCheck(out errMsg))
                        return false;
                    else
                    {
                        try
                        {
                            foreach (RemoteCommon.ImageSaveInfo img in lst)
                            {
                                img.BINARY = (Byte[])ApplicationCommon.ReflectionHelper.GetObjectProperty(img.COLUMN.ToUpper(), info);
                            }
                            InitializePst(info).InsertByImages(lst);
                            return true;
                        }
                        catch (Exception ex)
                        {
                            errMsg += ex.Message;
                            return false;
                        }
                    }
                }
                else
                {
                    try
                    {
                        foreach (RemoteCommon.ImageSaveInfo img in lst)
                        {
                            img.BINARY = (Byte[])ApplicationCommon.ReflectionHelper.GetObjectProperty(img.COLUMN.ToUpper(), info);
                        }
                        InitializePst(info).InsertByImages(lst);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        errMsg += ex.Message;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                errMsg += ex.Message;
                LogWrite.WriteErrorLogs(errMsg, ErrorLogType.Sql);
                return false;
            }
        }

        public bool Update(DataRow dr, out string errMsg)
        {
            errMsg = string.Empty;
            try
            {
                ISqlOperateLog info = (ISqlOperateLog)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, _info.InfoType);
                IDataCheck d = info as IDataCheck;
                info.OperateType = SystemOperateType.修改;
                if (d != null)
                {
                    if (!d.DataCheck(out errMsg))
                        return false;
                    else
                    {
                        try
                        {
                            InitializePst(info).Update();
                        }
                        catch (Exception ex)
                        {
                            errMsg += ex.Message;
                            return false;
                        }
                        return true;
                    }
                }
                else
                {
                    try
                    {
                        InitializePst(info).Update();
                    }
                    catch (Exception ex)
                    {
                        errMsg += ex.Message;
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg += ex.Message;
                LogWrite.WriteErrorLogs(errMsg, ErrorLogType.Sql);
                return false;
            }
        }

        public bool UpdateByImages(DataRow dr, out string errMsg, List<RemoteCommon.ImageSaveInfo> lst)
        {
            errMsg = string.Empty;
            try
            {
                ISqlOperateLog info = (ISqlOperateLog)ApplicationCommon.ReflectionHelper.ReflectionFromDataRow(dr, _info.InfoType);
                IDataCheck d = info as IDataCheck;
                info.OperateType = SystemOperateType.修改;
                if (d != null)
                {
                    if (!d.DataCheck(out errMsg))
                        return false;
                    else
                    {
                        try
                        {
                            foreach (RemoteCommon.ImageSaveInfo img in lst)
                            {
                                img.BINARY = (Byte[])ApplicationCommon.ReflectionHelper.GetObjectProperty(img.COLUMN.ToUpper(), info);
                            }
                            InitializePst(info).UpdateByImages(lst);
                        }
                        catch (Exception ex)
                        {
                            errMsg += ex.Message;
                            return false;
                        }
                        return true;
                    }
                }
                else
                {
                    try
                    {
                        foreach (RemoteCommon.ImageSaveInfo img in lst)
                        {
                            img.BINARY = (Byte[])ApplicationCommon.ReflectionHelper.GetObjectProperty(img.COLUMN.ToUpper(), info);
                        }
                        InitializePst(info).UpdateByImages(lst);
                    }
                    catch (Exception ex)
                    {
                        errMsg += ex.Message;
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                errMsg += ex.Message;
                LogWrite.WriteErrorLogs(errMsg, ErrorLogType.Sql);
                return false;
            }
        }

        public bool Delete(string id, out string errMsg)
        {
            errMsg = string.Empty;
            try
            {
                ISqlOperateLog info = (ISqlOperateLog)Activator.CreateInstance(_info.InfoType);
                info.OperateType = SystemOperateType.删除;
                InitializePst(info).Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                LogWrite.WriteErrorLogs(errMsg, ErrorLogType.Sql);
                return false;
            }
        }
        #endregion

        public PersistentBase InitializePst(object info)
        {
            return (PersistentBase)Activator.CreateInstance(_info.PstType, info);
        }

        public PersistentBase InitializePst()
        {
            object info = Activator.CreateInstance(_info.InfoType);
            return (PersistentBase)Activator.CreateInstance(_info.PstType, info);
        }

        public bool IsChanged
        {
            get
            {
                return GetTableIsChanged(_dt);
            }
        }

        public static bool GetTableIsChanged(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                if (dr.RowState == DataRowState.Added || dr.RowState == DataRowState.Modified || dr.RowState == DataRowState.Deleted)
                    return true;
            }
            return false;
        }

        public bool Save()
        {
            using (DevExpress.Utils.WaitDialogForm frm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在保存数据 ..."))
            {
                string msg = string.Empty;
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    DataRow dr = _dt.Rows[i];
                    string errMsg = string.Empty;
                    #region 处理行
                    switch (dr.RowState)
                    {
                        case DataRowState.Added:
                            frm.Caption = string.Format("正在对{0}行执行新增操作...", i);
                            if (Insert(dr, out errMsg))
                                dr.AcceptChanges();
                            else
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                        case DataRowState.Modified:
                            frm.Caption = string.Format("正在对{0}行执行修改操作...", i);
                            if (Update(dr, out errMsg))
                                dr.AcceptChanges();
                            else
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                        case DataRowState.Deleted:
                            frm.Caption = string.Format("正在对{0}行执行删除操作...", i);
                            if(!Delete(dr["guid", DataRowVersion.Original].ToString(), out errMsg))
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                    }
                    #endregion
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg);
                    LogWrite.WriteErrorLogs(msg, ErrorLogType.Sql);
                    return false;
                }
                else
                {
                    _dt.AcceptChanges();
                    //MessageBox.Show("保存成功！");
                    return true;
                }
            }
        }

        public bool SaveByImages(List<RemoteCommon.ImageSaveInfo> lst)
        {

            using (DevExpress.Utils.WaitDialogForm frm = new DevExpress.Utils.WaitDialogForm("请稍后", "正在保存数据 ..."))
            {
                string msg = string.Empty;
                for (int i = 0; i < _dt.Rows.Count; i++)
                {
                    DataRow dr = _dt.Rows[i];
                    string errMsg = string.Empty;
                    #region 处理行
                    switch (dr.RowState)
                    {
                        case DataRowState.Added:
                            frm.Caption = string.Format("正在对{0}行执行新增操作...", i);
                            if (InsertByImages(dr, out errMsg, lst))
                                dr.AcceptChanges();
                            else
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                        case DataRowState.Modified:
                            frm.Caption = string.Format("正在对{0}行执行修改操作...", i);
                            if (UpdateByImages(dr, out errMsg, lst))
                                dr.AcceptChanges();
                            else
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                        case DataRowState.Deleted:
                            frm.Caption = string.Format("正在对{0}行执行删除操作...", i);
                            if(!Delete(dr["guid", DataRowVersion.Original].ToString(), out errMsg))
                                msg += string.Format("第{0}行数据错误，未能保存。\r错误原因：\r{1}\r", i + 1, errMsg);
                            break;
                    }
                    #endregion
                }
                if (msg.Length > 0)
                {
                    MessageBox.Show(msg);
                    LogWrite.WriteErrorLogs(msg, ErrorLogType.Sql);
                    return false;
                }
                else
                {
                    _dt.AcceptChanges();
                    //MessageBox.Show("保存成功！");
                    return true;
                }
            }
        }

        public bool SaveByImage(string columnName)
        {
            RemoteCommon.ImageSaveInfo ims = new RemoteCommon.ImageSaveInfo(columnName);
            List<RemoteCommon.ImageSaveInfo> lst = new List<RemoteCommon.ImageSaveInfo>();
            lst.Add(ims);
            return SaveByImages(lst);
        }
    }
}
