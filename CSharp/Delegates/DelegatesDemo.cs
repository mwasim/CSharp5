using System;

namespace CSharp.Delegates
{
    public class DelegatesDemo
    {
        public static void Example1()
        {
            //Both of the following instantiations are same
            CalculateArea ca = DelegatesExamples.RectangleArea;
            var ca2 = new CalculateArea(DelegatesExamples.RectangleArea);

            Console.WriteLine("Rectangle 1 Area: {0}", ca(5, 8));
            Console.WriteLine("Rectangle 2 Area: {0}", ca2(6, 12));
        }

        public static void AddMultiplyNumbers()
        {
            var Sum = new AddMultNumbers(DelegatesExamples.AddNumbers);
            AddMultNumbers Multiply = DelegatesExamples.MultiplyNumbers;

            var num1 = 5;
            var num2 = 8;

            Console.WriteLine("Sum of {0} and {1} is: {2}", num1, num2, Sum(num1, num2));
            Console.WriteLine("Product of {0} and {1} is: {2}", num1, num2, Multiply(num1, num2));
        }

        public static void DelegateTarget()
        {
            CalculateArea ca = DelegatesExamples.RectangleArea;
            var shape = new Shape();
            CalculateArea ca2 = shape.Area;

            Console.WriteLine("First Delegate:");
            Console.WriteLine("Rectangle Area: {0}", ca(5, 6));
            Console.WriteLine("Method: {0}", ca.Method);
            Console.WriteLine("Target: {0}", ca.Target);

            Console.WriteLine("\n\nSecond Delegate:");
            Console.WriteLine("Rectangle Area: {0}", ca2(6, 8));
            Console.WriteLine("Method: {0}", ca2.Method);
            Console.WriteLine("Target: {0}", ca2.Target);

            if (ca2.Target == shape)
            {
                Console.WriteLine("This delegate's target is Shape Object.");
            }
        }

        public static void MulticastDelegateExample()
        {
            AddMultNumbers addMult = DelegatesExamples.AddNumbers;
            addMult += DelegatesExamples.MultiplyNumbers;

            //iterate over invocation list
            foreach (var item in addMult.GetInvocationList())
            {
                var d = ((AddMultNumbers)item);

                var n1 = 5;
                var n2 = 6;
                Console.WriteLine("\nMethod: {0}", d.Method);
                Console.WriteLine("Result of {0} and {1}: {2}", n1, n2, d(5, 6));

                if (d.Method.Name == "AddNumbers")
                    Console.WriteLine("This is '{0}' Method.", d.Method.Name);
                else if (d.Method.Name == "MultiplyNumbers")
                    Console.WriteLine("This is '{0}' Method.", d.Method.Name);
            }

            Console.WriteLine("\n\nMultiplication of {0} and {1} is: {2}", 5, 10, addMult(5, 10));

            addMult -= DelegatesExamples.MultiplyNumbers;
            Console.WriteLine("Sum of {0} and {1} is: {2}", 5, 10, addMult(5, 10));

            addMult -= DelegatesExamples.AddNumbers;

            if (addMult == null)
            {
                Console.WriteLine("\n\nDelegate is not pointing to any method.");
            }
        }

        public static void DelegateComposition()
        {
            var sum = new AddMultNumbers(DelegatesExamples.AddNumbers);
            var multiply = new AddMultNumbers(DelegatesExamples.MultiplyNumbers);

            var addMult = sum + multiply;
            foreach (AddMultNumbers item in addMult.GetInvocationList())
            {
                item(8, 5);
            }

            Console.WriteLine("Result: {0}", addMult(5, 7));


            addMult = (AddMultNumbers)Delegate.Remove(addMult, multiply);
            Console.WriteLine("After removing multiply method.");
            addMult(10, 5);
            addMult = (AddMultNumbers)Delegate.RemoveAll(addMult, sum);
            Console.WriteLine("After removing all sum methods");

            if (addMult == null)
            {
                Console.WriteLine("Now delegate is not pointing to any method.");
            }
        }

        public static void CoverianceDelegateExample()
        {
            var ra = new RectangleArea();
            var ta = new TriangleArea();

            var covDlg = new CoverianceDelegate(ra.GetRectArea);
            covDlg();
            covDlg = new CoverianceDelegate(ta.GetTrgArea);
            covDlg();
        }

        public static void ContravarianceDelegateExample()
        {
            var ta = new TriangleArea();
            var contDlg = new ContraVerianceDelegate(DelegatesExamples.PassingRectArea);
            contDlg(ta);

            contDlg = new ContraVerianceDelegate(DelegatesExamples.PassingTriangleArea);
            contDlg(ta);
        }

        public static void GenericAddMultiplyExample()
        {
            AddMultNumbers<int> sumInt = DelegatesExamples.AddNumbers;
            AddMultNumbers<float> sumFloat = DelegatesExamples.AddNumbers;

            AddMultNumbers<int> multiplyInt = DelegatesExamples.MultiplyNumbers;
            AddMultNumbers<float> multiplyFloat = DelegatesExamples.MultiplyNumbers;

            AddMultNumbers<int, float> trgArea = DelegatesExamples.CaculateTriangleArea;

            sumInt(5, 6);
            sumFloat(5.5F, 6.8F);

            multiplyInt(5, 6);
            multiplyFloat(5.5F, 6.50F);
            trgArea(5, 7);
        }

        public static void AnonymousMethodExample()
        {
            AddMultNumbers<int> sum = delegate (int a, int b)
            {
                var addition = a + b;
                Console.WriteLine("Sum of {0} and {1} is: {2}", a, b, addition);
                return addition;
            };

            var result = sum(45, 75);
            Console.WriteLine("Result: {0}", result);
        }

        public static event AddMultNumbers<int> EventToAddMultiply;
        public static void EventToAddMultiplyExample()
        {
            var sum = new AddMultNumbers<int>(DelegatesExamples.AddNumbers);
            var multiply = new AddMultNumbers<int>(DelegatesExamples.MultiplyNumbers);
            EventToAddMultiply += sum; //adding delegate instance to the event
            EventToAddMultiply += multiply;

            //Methods fired: AddNumbers, MultiplyNumbers are also known as event handlers
            EventToAddMultiply(5, 8);//firing the event
        }


        public static void ProductDelegateExample()
        {
            var prod = new Product(6);

            prod.ProductEvent += new ProductDelegate(prod.Display);
            prod.RaiseEvent();
        }


        public static void EventAccessorExample()
        {
            var r = new Rect(5, 8);
            r.CalculateRectAreaEvent += new CalculateRectangleArea(r.DisplayArea);
            r.RaiseEvent();
            r.CalculateRectAreaEvent -= new CalculateRectangleArea(r.DisplayArea);
        }
    }
}
