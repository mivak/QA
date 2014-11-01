########################################################
# UI map for XYZ
########################################################
from sikuli import *
########################################################

class Calc:
    calcNav = Pattern("calcNav.png").targetOffset(-40,14)
    plus = "plus.png"
    minus = "minus.png"
    multiply = "multiply.png"
    divide = "divide.png"
    equals = "equals.png"
    zero = "zero.png"
    four = "four.png"
    eight = "eight.png"
    resultFour = "resultFour.png"
    resultTwelve = "resultTwelve.png"
    resultThirtyTwo = "resultThirtyTwo.png"
    resultTwo = "resultTwo.png"
    zeroDivide = "zeroDivide.png"
    closeButton = Pattern("closeButton.png").targetOffset(31,-4)