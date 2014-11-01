import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class Differences(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToPicture(self):
        RunBrowserToUrl("chrome","http://screencast.com/t/FlrpTtmRV")
        wait(Dif.messageCounter, 30)
    
    def test_002_HighlightDifferences(self):
        wait(3)
        Dif.messageCounter.highlight(3)
        MessageCounterRight = Dif.messageCounter.offset(645,0)
        MessageCounterRight.highlight(3)

        wait(1)
        Dif.bird.highlight(3)
        birdRight = Dif.bird.offset(645,0)
        birdRight.highlight(3)

        wait(1)
        Dif.friendsCounter.highlight(3)
        friendsCounterRight = Dif.friendsCounter.offset(645,0)
        friendsCounterRight.highlight(3)

        wait(1)
        Dif.like.highlight(3)
        likeRight = Dif.like.offset(645,0)
        likeRight.highlight(3)
             
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(Differences)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Differences Report' )
    runner.run(suite)
    outfile.close()

