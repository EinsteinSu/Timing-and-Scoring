namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public interface IDataManager
    {
        object CurrentItem { get; set; }
        void Add(object item);

        void Edit(object item);

        object GetItemSource();

        void Save();

        void Delete();

        void Import(string path);

        void Export(string fileName);

        object NewItem();

        void Copy();

        void Paste();
    }
}