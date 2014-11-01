import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class GoogleSearch(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToGoogle(self):
        RunBrowserToUrl("chrome","http://google.com")
        wait(HW.googleSearchInput,30)
    
    def test_002_SearchForTelerikAcademy(self):
        type(HW.googleSearchInput, "Telerik academy")
        type(Key.ENTER)
        wait(HW.searchAssert,10)
             
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(GoogleSearch)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Google Search Report' )
    runner.run(suite)
    outfile.close()

