namespace WaterPolo.Simple.DataCenter.DataEdit
{
    public interface IDataManager
    {
        void Refresh();

        void Add();

        void Save();

        void Import(string path);

        void Export(string fileName);
    }
}