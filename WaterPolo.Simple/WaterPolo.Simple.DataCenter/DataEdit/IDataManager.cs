namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public interface IDataManager
    {
        void Add(object Item);

        void Edit();

        object CurrentItem { get; set; }

        object GetItemSource();

        void Save();

        void Delete();

        void Import(string path);

        void Export(string fileName);

        object NewItem();
    }
}