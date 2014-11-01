import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class MinimizeActiveWindows(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass
    
    def test_001_OpenActiveFirefoxWindows(self):
        type("d", KEY_WIN); sleep(1)
        for i in range(0,5):
            type("r", KEY_WIN); sleep(1)
            type("firefox"); sleep(1)
            type(Key.ENTER)
        wait(HW.minimizeFirefox,10)
             
    def test_002_MinimizeActiveFirefoxWindows(self):
        while exists(HW.minimizeFirefox):
            click(HW.minimizeFirefox)
            
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(MinimizeActiveWindows)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Minimize Active Windows Report' )
    runner.run(suite)
    outfile.close()

