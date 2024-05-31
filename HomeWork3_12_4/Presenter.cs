using System.Windows;

namespace HomeWork3_12_4;

public class Presenter {

    private MainWindow _window;
    private CalculatorModel _model;

    private float? TryGetOperand1 {
        get { 
            var strVal = _window.txtOperand1.Text; 
            if (float.TryParse(strVal, out var result)) {
                return result;
            } else {
                return null;
            }
        }
    }

    private float? TryGetOperand2 {
        get {
            var strVal = _window.txtOpedand2.Text;
            if (float.TryParse(strVal, out var result)) {
                return result;
            } else {
                return null;
            }
        }
    }

    public Presenter(MainWindow view, CalculatorModel model) {
        _model = model;
        _window = view;

        _window.btnSum.Click += BtnSum_Click;
        _window.btnDiv.Click += BtnDiv_Click;
        _window.btnSub.Click += BtnSub_Clik;
        _window.btnMul.Click += BtnMul_Clik;
    }

   

    private void SetResultValue(float res) {
        _window.txtResult.Text = res.ToString();
    }

    private void SetError(string errorMessage) {
        _window.txtResult.Text = errorMessage;
    }

    private void DoOperation(EArythmeticOperation operation) {
        _model.Operand1 = TryGetOperand1;
        _model.Operand2 = TryGetOperand2;

        try {
            var mathResult = _model.DoOperation(operation);
            SetResultValue(mathResult);
        } catch (Exception ex) {
            SetError(ex.Message);
        }
    }

    private void BtnSum_Click(object sender, System.Windows.RoutedEventArgs e) {
        DoOperation(EArythmeticOperation.Plus);
    }

    private void BtnDiv_Click(object sender, System.Windows.RoutedEventArgs e) {
        DoOperation(EArythmeticOperation.Divide);
    }
    private void BtnSub_Clik(object sender, System.Windows.RoutedEventArgs e) {
        DoOperation(EArythmeticOperation.Minus);
    }
    private void BtnMul_Clik(object sender, System.Windows.RoutedEventArgs e) {
        DoOperation(EArythmeticOperation.Multiply);
    }
}
