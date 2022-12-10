namespace Calc
{
    class Presenter
    {
        View view;
        Model model;

        public Presenter(Model m, View v)
        {
            model = m;
            view = v;
        }

        public void buttonClick()
        {
            double a = view.getValue("a = ");
            double b = view.getValue("b = ");
            char calc = view.getCalc("Операция = ");
            model.setX(a);
            model.setY(b);
            model.setCalc(calc);
            double result = model.result();
            view.print(result, "Sum =");
        }

    }
}
