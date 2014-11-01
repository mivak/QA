import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class SkypeMessage(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_OpenSkype(self):
        type("d",KEY_WIN); sleep(1)
        type(Key.WIN); sleep(1)
        type(HW.winSearchInput, "skype"); sleep(1)
        type(Key.ENTER)
        wait(HW.searchInput,30)
    
    def test_002_SendMessage(self):
        type(HW.searchInput, "qa")
        click(HW.qa)
        wait(1)
        type(HW.messageInput, "test message from sikuli :)")
        wait(1)
        type(Key.ENTER)
        wait(HW.testMessage,10)
             
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(SkypeMessage)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Skype Message Report' )
    runner.run(suite)
    outfile.close()

