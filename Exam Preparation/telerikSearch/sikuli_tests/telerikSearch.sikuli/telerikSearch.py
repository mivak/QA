import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class TelerikSearch(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToGoogle(self):
        RunBrowserToUrl("chrome","http://google.com")
        wait(HW.googleSearchInput,30)
    
    def test_002_SearchForTelerikAcademy(self):
        click(HW.images)
        wait(HW.images, 5)
        type(HW.googleSearchInput, "Telerik academy")
        type(Key.ENTER)
        wait(HW.picture,10)
        rightClick(HW.picture)
        wait(HW.context)
        type(Key.DOWN * 5)
        wait(1)
        type(Key.ENTER)
        wait(1)
        type(Key.F6)
        type("v", KEY_CTRL)
        wait(1)
        type(Key.ENTER)
             
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(TelerikSearch)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Telerik Search Report' )
    runner.run(suite)
    outfile.close()

