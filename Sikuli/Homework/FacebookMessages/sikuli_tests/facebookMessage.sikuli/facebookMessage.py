import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class FacebookMessage(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToFacebook(self):
        RunBrowserToUrl("chrome","http://www.facebook.com/")
        wait(HW.friendSearch, 30)
    
    def test_002_SendMessages(self):
        type(HW.friendSearch, "asya georgieva")
        wait(HW.asyaPhoto, 10)
        click(HW.asyaPhoto)
        wait(HW.messageInput, 10)
        click(HW.messageInput)
        for i in range(4):
            type(HW.messageInput, "test message from sikuli")
            wait(1)
            type(Key.ENTER)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(FacebookMessage)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Facebook Message Report' )
    runner.run(suite)
    outfile.close()

