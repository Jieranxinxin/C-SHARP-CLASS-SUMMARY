using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 他的目标是采用广泛性和可交互性的形式来表示算法和数据结构
 * 可以进行参数化
 * T是占位符，表示某种可能的类型
 * 
 * 
 * 
 * 
 * 
 */
namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust_one = new Customer();
            Customer cust_two = new Customer();
            Customer cust_three = new Customer();
            cust_one.CustName = "LI lei";
            cust_one.RewardPoints = 100;
            cust_two.CustName = "HanMeimei";
            cust_two.RewardPoints = 100;
            cust_three.CustName = "xinxin";
            cust_three.RewardPoints = 200;


            Coffee_Latte coffee = new Coffee_Latte();
            coffee.CostPoints = 15;
            Coffee_Cappuccino coffee1= new Coffee_Cappuccino();
            coffee1.CostPoints = 20;
            Coffee_Mocca coffee2= new Coffee_Mocca();
            coffee2.CostPoints = 25;

            cust_one.BuyCoffee(coffee);
            Console.WriteLine("顾客" + cust_one.CustName+"购买了"+coffee.getCoffeeName());
            Console.WriteLine("顾客" + cust_one.CustName+"扣除积分"+coffee.CostPoints);
            Console.WriteLine("顾客" + cust_one.CustName + "剩余积分"+cust_one.RewardPoints);

            cust_two.BuyCoffee(coffee1);
            Console.WriteLine("顾客" + cust_two.CustName + "购买了" + coffee1.getCoffeeName());
            Console.WriteLine("顾客" + cust_two.CustName + "扣除积分" + coffee1.CostPoints);
            Console.WriteLine("顾客" + cust_two.CustName + "剩余积分" + cust_two.RewardPoints);

            cust_three.BuyCoffee(coffee2);
            Console.WriteLine("顾客" + cust_three.CustName + "购买了" + coffee2.getCoffeeName());
            Console.WriteLine("顾客" + cust_three.CustName + "扣除积分" + coffee2.CostPoints);
            Console.WriteLine("顾客" + cust_three.CustName + "剩余积分" + cust_three.RewardPoints);

            Console.ReadKey();
        }
    }


}
public abstract class Coffee
{
    private int costPoints;
    public int CostPoints
    {
        get
        {
            return costPoints;
        }
        set
        {
            costPoints = value;
        }
    }

    //抽象的，在派生类里要重新
    public abstract string getCoffeeName();

}

public class Coffee_Latte:Coffee
{
    public override string getCoffeeName()
    {
        return "Latte";
    }

}
public class Coffee_Mocca : Coffee
{
    public override string getCoffeeName()
    {
        return "Latte";
    }

}
public class Coffee_Cappuccino : Coffee
{
    public override string getCoffeeName()
    {
        return "Latte";
    }

}
/*
public class Coffee_Latte
{
    private int costPoints;
    public int CostPoints
    {
        get
        {
            return costPoints;
        }
        set
        {
            costPoints = value;
        }
    }
    public string getCoffeeName()
    {
        return "Latte";
    }
}

public class Coffee_Mocca
{
    private int costPoints;
    public int CostPoints
    {
        get
        {
            return costPoints;
        }
        set
        {
            costPoints = value;
        }
    }
    public string getCoffeeName()
    {
        return "Mocca";
    }
}
public class Coffee_Cappuccino
{
    private int costPoints;
    public int CostPoints
    {
        get
        {
            return costPoints;
        }
        set
        {
            costPoints = value;
        }
    }
    public string getCoffeeName()
    {
        return "Cappuccino";
    }
}
*/
public class Customer
{
    private string custName;
    private int rewardPoints;
    public string CustName
    {
        get
        {
            return custName;
        }
        set
        {
            custName = value;
        }
    }
    public int RewardPoints
    {
        get
        {
            return rewardPoints;
        }
        set
        {
            rewardPoints = value;
        }

    }
    /*
    public void BuyCoffee(Coffee_Latte c1)
    {
        if (this.RewardPoints < c1.CostPoints)
        {
            Console.WriteLine("积分不够");
        }
        else
        {
            //-=
            this.RewardPoints = this.RewardPoints - c1.CostPoints;
        }
    }
    public void BuyCoffee(Coffee_Mocca c2)
    {
        if (this.RewardPoints < c2.CostPoints)
        {
            Console.WriteLine("积分不够");
        }
        else
        {
            //-=
            this.RewardPoints = this.RewardPoints - c2.CostPoints;
        }
    }
    public void BuyCoffee(Coffee_Cappuccino c3)
    {
        if (this.RewardPoints < c3.CostPoints)
        {
            Console.WriteLine("积分不够");
        }
        else
        {
            //-=
            this.RewardPoints = this.RewardPoints - c3.CostPoints;
        }
    }
    */
    //泛型
    public void BuyCoffee<T>(T coffee) where T:Coffee
    {
        if (this.RewardPoints < coffee.CostPoints)
        {
            Console.WriteLine("积分不够");
        }
        else
        {
            //-=
            this.RewardPoints = this.RewardPoints - coffee.CostPoints;
        }
    }

}