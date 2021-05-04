import datetime
import sys
import os

dirname         = os.path.dirname(__file__)
aboutFilename   = os.path.join(dirname, 'FlowModel\AboutView.Designer.cs')
#proj            = os.path.join(dirname, 'OS_CP\OS_CP.View.csproj')
sub             = "this.Version.Text = "
#projSub         = "<ApplicationVersion>" 
curdate         = datetime.datetime.today()
date            = curdate.strftime("%d/%m/%Y")
files           = [aboutFilename]

if __name__ == "__main__":
    if len(sys.argv) > 1:
        #INPROGRAM DISPLAY VERSION
        for filename in files:
            file = open(filename, "r", encoding="utf-8")
            lines = file.readlines()
            file.close()
            i = 0
            for text in lines:
                if sub in text:
                    break;
                i = i + 1
            lines[i] = "            this.Version.Text = " + '"' + "Version: " + sys.argv[1] + '    ' + date + '"' + ";" + '\n'  
            file = open(filename, "w", encoding="utf-8")
            file.writelines(lines)

        #DEFAULT PUBLISH VERSION
        #file = open(proj, "r")
        #lines = file.readlines()
        #file.close()
        #i = 0
        #for text in lines:
            #if projSub in text:
                #break;
            #i = i + 1
        #lines[i] = "    <ApplicationVersion>"+ sys.argv[1] +".0.0</ApplicationVersion>" + '\n'  
        #file = open(proj, "w")
        #file.writelines(lines)

        print("Version number bumped to " + sys.argv[1])
    else:
        print("Relaunch script and type version number. ($python bump-version.py 0.0)")
