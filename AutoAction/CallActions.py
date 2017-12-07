import os

def CallLeftClick(x,y,delay):
    os.system("AutoActionCMD.exe mouse left "+str(x)+" "+str(y)+" "+str(delay))

def CallRightClick(x,y,delay):
    os.system("AutoActionCMD.exe mouse right "+str(x)+" "+str(y)+" "+str(delay))

def CallMiddleClick(x,y,delay):
    os.system("AutoActionCMD.exe mouse middle "+str(x)+" "+str(y)+" "+str(delay))

def CallKeyboardClick(data):
    os.system("AutoActionCMD.exe key \""+str(data)+"\"")

def CallWait(delay):
    os.system("AutoActionCMD.exe wait "+str(delay))

def CallProcess(command):
    os.system("AutoActionCMD.exe process "+str(command)+" \"\"")

def CallProcess(command, args):
    os.system("AutoActionCMD.exe process "+str(command)+" "+str(args))

def CallProcessWait(command):
    os.system("AutoActionCMD.exe processwait "+str(command)+" \"\"")

def CallProcessWait(command, args):
    os.system("AutoActionCMD.exe processwait "+str(command)+" "+str(args))