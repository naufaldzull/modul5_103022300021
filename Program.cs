// See https://aka.ms/new-console-template for more information

using System;
internal class Program
{
    class SimpleDataBase<T>
    {
        private List<T> stroredData;
        private List<DateTime> inputDates;
        public SimpleDataBase()
        {
            stroredData = new List<T>();
            inputDates = new List<DateTime>();

        }
        public void addNewData(T data)
        {
            stroredData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData()
        {
            for (int i = 0; i < stroredData.Count; i++)
            {
                Console.WriteLine($"Data {i} berisi: {stroredData[i]}, yang disimpan pada waktu {inputDates[i]}");
            }
        }

    }
    public static void Main()
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.addNewData(10);
        data.addNewData(30);
        data.addNewData(22);
        data.printAllData();
        SimpleDataBase<string> stringData = new SimpleDataBase<string>();

        stringData.printAllData();
    }
}
