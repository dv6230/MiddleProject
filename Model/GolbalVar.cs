using SqlSugar;
using System.Collections.Generic;

namespace MiddleProject.Model
{
    class GolbalVar
    {
        static public int auth = 0;
        static public int userId = 0;
        static public string userName = "";
        
        static public List<Product> purchaseList = new List<Product>();
        static public List<string> ingredientList = new List<string>();
        static public List<string> userPermissionList = new List<string>();

        static public Dictionary<string, List<Product>> productDictionary = new Dictionary<string, List<Product>>();

        static public string[] sweetLevel = { "無糖", "三分", "五分", "七分", "全糖" };
        static public string[] temperature = { "正常", "少冰", "微冰", "去冰", "常溫" };

        static public SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = DBProduceStr.DBstr,
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true,
            LanguageType = LanguageType.English             
        }); 

    }



    //class SimpleData
    //{
    //    public SimpleData()
    //    {
    //        createIngredient();
    //        createProduct();
    //    }

    //    void createIngredient()
    //    {
    //        GolbalVar.ingredientList.Add("珍珠"); //0
    //        GolbalVar.ingredientList.Add("布丁"); //1
    //        GolbalVar.ingredientList.Add("仙草"); //2
    //        GolbalVar.ingredientList.Add("奶蓋"); //3
    //        GolbalVar.ingredientList.Add("粉條"); //4
    //        GolbalVar.ingredientList.Add("愛玉"); //5
    //        GolbalVar.ingredientList.Add("寒天"); //6
    //        GolbalVar.ingredientList.Add("蒟蒻"); //7
    //        GolbalVar.ingredientList.Add("蜂蜜"); //8
    //        GolbalVar.ingredientList.Add("楓糖"); //9
    //        GolbalVar.ingredientList.Add("冰淇淋"); //10
    //    }

    //    void createProduct()
    //    {
    //        List<string> emt = GolbalVar.ingredientList;
    //        GolbalVar.products = new List<Product> {
    //            new Product("奶茶", 30 ,ingredientIdToList(new int[]{0,1,2,3})),
    //            new Product("珍珠奶茶", 50 ,ingredientIdToList(new int[]{0,2,3})),
    //            new Product("紅茶", 20 , ingredientIdToList(new int[]{ 0,2,3,4,5,6,7})) ,
    //            new Product("綠茶", 20 , ingredientIdToList(new int[]{2,3})),
    //            new Product("麥茶", 20 , ingredientIdToList(new int[]{0})),
    //            new Product("黑糖牛奶", 55 ,ingredientIdToList(new int[]{0,1,2,4})),
    //            new Product("玫瑰茶", 55 , ingredientIdToList(new int[]{8,9})),
    //            new Product("百香綠茶", 45 , ingredientIdToList(new int[]{5,6})),
    //            new Product("柳橙綠茶", 30 , ingredientIdToList(new int[]{5,6})),
    //            new Product("檸檬汁", 30 , ingredientIdToList(new int[]{5,6,7})),
    //            new Product("阿華田",45 , ingredientIdToList(new int[]{1,2,10})),
    //            new Product("香橙果粒茶",80 , ingredientIdToList(new int[]{0,1,2,3,4,5,6,7})),
    //            new Product("葡萄柚果粒茶",80 , ingredientIdToList(new int[]{0,1,2,3,4,5,6,7})),
    //        };
    //    }

    //    public void FillListBox(System.Windows.Forms.ListBox lb)
    //    {
    //        foreach (var item in GolbalVar.products)
    //        {
    //            lb.Items.Add(item.Name);
    //        }
    //    }

    //    List<string> ingredientIdToList(int[] idAry)
    //    {
    //        List<string> list = new List<string>();
    //        foreach (var id in idAry)
    //        {
    //            if (id < GolbalVar.ingredientList.Count)
    //            {
    //                list.Add(GolbalVar.ingredientList[id]);
    //            }
    //        }
    //        return list;
    //    }

    //}

}
