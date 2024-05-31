namespace HomeWork3_12_4;

public enum EArythmeticOperation {
    Plus,
    Minus,
    Multiply,
    Divide
}

public class CalculatorModel {

    public float? Operand1 { get; set; }
    public float? Operand2 { get; set; }

    public float DoOperation(EArythmeticOperation operation) {
        if (Operand1 is null)
            throw new Exception("Некоректне значення в операнді #1");

        if (Operand2 is null)
            throw new Exception("Некоректне значення в операнді #2");

        switch (operation) {
            case EArythmeticOperation.Plus:
                return Operand1.Value + Operand2.Value;

            case EArythmeticOperation.Divide:
                if (Operand2 == 0)
                    throw new Exception("Ділити на нуль поки що не дозволено!");
                else
                    return Operand1.Value / Operand2.Value;

            case EArythmeticOperation.Multiply:
                return Operand1.Value * Operand2.Value;

            case EArythmeticOperation.Minus:
                return Operand1.Value - Operand2.Value;

            default:
                throw new Exception("Некоректне значення в операнді");
                
                
        }
    }
}
      

    