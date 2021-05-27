import datetime
import sys
import os

dirname                     = os.path.dirname(__file__)

aboutFilename               = os.path.join(dirname, 'FlowModel\AboutView.Designer.cs')
aboutSub                    = "this.Version.Text = "

setupFilename               = os.path.join(dirname, 'FlowModel.Setup\FlowModel.Setup.vdproj')
setupSub                    = '"' + "ProductVersion" + '"'

assemblyViewFilename        = os.path.join(dirname, 'FlowModel\Properties\AssemblyInfo.cs')
assemblyModelFilename       = os.path.join(dirname, 'FlowModel.Model\Properties\AssemblyInfo.cs')
assemblyPresenterFilename   = os.path.join(dirname, 'FlowModel.Presenter\Properties\AssemblyInfo.cs')
assemblyVersionSub          = "[assembly: AssemblyVersion("
assemblyFileVersionSub      = "[assembly: AssemblyFileVersion("

curdate                     = datetime.datetime.today()
date                        = curdate.strftime("%d/%m/%Y")

files                       = [assemblyViewFilename, assemblyModelFilename, assemblyPresenterFilename]

if __name__ == "__main__":
    if len(sys.argv) > 1:
        #INPROGRAM DISPLAY VERSION
        file = open(aboutFilename, "r", encoding="utf-8")
        lines = file.readlines()
        file.close()
        i = 0
        for text in lines:
            if aboutSub in text:
                break;
            i = i + 1
        lines[i] = "            this.Version.Text = " + '"' + "Version: " + sys.argv[1] + '    ' + date + '"' + ";" + '\n'  
        file = open(aboutFilename, "w", encoding="utf-8")
        file.writelines(lines)

        #SETUP VERSION
        file = open(setupFilename, "r")
        lines = file.readlines()
        file.close()
        i = 0
        for text in lines:
            if setupSub in text:
                break;
            i = i + 1
        lines[i] = "        "+'"' + "ProductVersion" + '"' + " = " + '"' + "8:"+ sys.argv[1] + ".0" + '"' + '\n'  
        file = open(setupFilename, "w")
        file.writelines(lines)
        
        #DEFAULT PUBLISH VERSION
        for filename in files:
            file = open(filename, "r")
            lines = file.readlines()
            file.close()

            i = 0
            for text in lines:
                if assemblyVersionSub in text:
                    break;
                i = i + 1
            lines[i] = "[assembly: AssemblyVersion(" + '"' + sys.argv[1] + '"' + ")]" + '\n'

            i = 0
            for text in lines:
                if assemblyFileVersionSub in text:
                    break;
                i = i + 1
            lines[i] = "[assembly: AssemblyFileVersion(" + '"' + sys.argv[1] + '"' + ")]" + '\n'

            file = open(filename, "w")
            file.writelines(lines)
        print("Version number bumped to " + sys.argv[1])
    else:
        print("Relaunch script and type version number. ($python bump-version.py 0.0)")
