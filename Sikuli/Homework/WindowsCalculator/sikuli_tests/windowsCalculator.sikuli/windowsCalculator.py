import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class WindowsCalculator(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_OpenWindowsCalculator(self):
        type("d", KEY_WIN)
        type("r", KEY_WIN)
        wait(1)
        type("calc.exe")
        type(Key.ENTER)
    
    def test_002_VerifySubtraction(self):
        click(Calc.eight)
        wait(0.5)
        click(Calc.minus)
        wait(0.5)
        click(Calc.four)
        wait(0.5)
        click(Calc.equals)
        wait(Calc.resultFour, 5)
    
    def test_003_VerifyAddition(self):
        click(Calc.eight)
        wait(0.5)
        click(Calc.plus)
        wait(0.5)
        click(Calc.four)
        wait(0.5)
        click(Calc.equals)
        wait(Calc.resultTwelve, 5)

    def test_004_VerifyMultiplication(self):
        click(Calc.eight)
        wait(0.5)
        click(Calc.multiply)
        wait(0.5)
        click(Calc.four)
        wait(0.5)
        click(Calc.equals)
        wait(Calc.resultThirtyTwo, 5)

    def test_005_VerifyDivision(self):
        click(Calc.eight)
        wait(0.5)
        click(Calc.divide)
        wait(0.5)
        click(Calc.four)
        wait(0.5)
        click(Calc.equals)
        wait(Calc.resultTwo, 5)

    def test_006_VerifyDivisionByZeroIsNotAllowed(self):
        click(Calc.eight)
        wait(0.5)
        click(Calc.divide)
        wait(0.5)
        click(Calc.zero)
        wait(0.5)
        click(Calc.equals)
        wait(Calc.zeroDivide, 5)
        click(Calc.closeButton)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(WindowsCalculator)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Windows Calculator Report' )
    runner.run(suite)
    outfile.close()

