import unittest
bdLibPath=os.path.abspath(sys.argv[0]+"..")
if not bdLibPath in sys.path: sys.path.append(bdLibPath)
from _lib import *

    
class DraggingCapitals(unittest.TestCase):
    
    def setUp(self):
        pass
    
    def tearDown(self):
        pass    
    
    def test_001_NavigateToDHtmlGoodies(self):
        RunBrowserToUrl("chrome","http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html")
        wait(HW.oslo,30)
    
    def test_002_DragAndDropCapitalsToCountries(self):
        dragDrop(HW.oslo, HW.norway)
        dragDrop(HW.stockholm, HW.sweden)
        dragDrop(HW.washington, HW.unitedStates)
        dragDrop(HW.copenhagen, HW.denmark)
        dragDrop(HW.seoul, HW.southKorea)
        dragDrop(HW.rome, HW.italy)
        dragDrop(HW.madrid, HW.spain)
        wait(1)
        exists(HW.result)
             
if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(DraggingCapitals)
    
    
    outfile = open("report.html", "w")
    runner = HTMLTestRunner.HTMLTestRunner(stream=outfile, title='Dragging Capitals Report' )
    runner.run(suite)
    outfile.close()