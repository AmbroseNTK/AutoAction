import pyautogui
import time

def CallLeftClick(x,y,delay=0,time=1,interval=0):
    pyautogui.click(x,y,time,interval,'left',delay)

def CallRightClick(x,y,delay=0,time=1,interval=0):
    pyautogui.click(x,y,time,interval,'right',delay)


def CallMiddleClick(x,y,delay=0,time=1,interval=0):
    pyautogui.click(x,y,time,interval,'middle',delay)

def CallClick(x,y,buttonName = 'left',delay=0,time=1,interval=0):
    pyautogui.click(x,y,time,interval,buttonName)

def CallKeyboardClick(data, delay=0):
    pyautogui.typewrite(data, interval=delay) 

def CallHotkey(firstKey, secondKey=""):
    pyautogui.hotkey(firstKey,secondKey)

def CallScrollV(x,y,amount):
    pyautogui.scroll(amount,x,y)

def CallScrollH(x,y,amount):
    pyautogui.hscroll(amount,x,y)

def CallWait(delay):
    time.sleep(delay)

def CallProcess(command):
    os.system(str(command)+" \"\"")

def CallProcess(command, args):
    os.system(str(command)+" "+str(args))

def CallProcessWait(command):
    os.system(str(command)+" \"\"")

def CallProcessWait(command, args):
    os.system(str(command)+" "+str(args))

def GetPos():
    return pyautogui.position()

def GetSize():
    return pyautogui.size()

def MakeMessage(text,alert=True,title=""):
    if(alert==True):
        return pyautogui.alert(text,title)
    else:
        return pyautogui.prompt(text,title)

def CallMoveMouse(x, y, delay, rel=False):
    if(rel == False):
        pyautogui.moveTo(x,y,delay)
    else:
        pyautogui.moveRel(x,y,delay)

def CallDrag(x,y,delay,rel=False):
    if(rel == False):
        pyautogui.dragTo(x,y,delay)
    else:
        pyautogui.dragRel(x,y,delay)

pyautogui.FAILSAFE=False