# Using The Access To .Net Forms Converter #

Steps to convert an Access Project (ADP) or database (MDB)

  1. Download AccessDotNetConverter zip file, unzip it in a folder, OR checkout project and open it in .net 2010 and Compile it.
  1. Make A backup Copy of the MDB/ADP of the MS Access database you want to convert.
  1. Run the AccessDotNetConverter.exe.  The first time you run the executable, you will be in "New Project" mode.

## Creating a New Project ##

A "Conversion Project" consists of 3 items of information:

  1. The location of the configuration file of the project.
  1. The root path to the .Net project that will receive converted forms
  1. The source MS Access database

After you select these 3 values, you can save the project, from the "File"->"Save Project" menu (Ctrl+S).

This will create the [Configuration File](ConfigurationFile.md) of the project.  You can edit the Configuration File as per instructions [here](ConfigurationFile.md)


## The Project Window ##
![https://msaccess-subversion-control.googlecode.com/svn/wiki/ConverterUI.png](https://msaccess-subversion-control.googlecode.com/svn/wiki/ConverterUI.png)

  1. The location of the configuration file of the project.  Click the "..." next to the field to select and load another project.
  1. The root path to the .Net project that will receive converted forms.  Click the "..." next to the field to select another path.
  1. The Source MS Access database. Click the "..." next to the field to select and load another MS Access database.
  1. List of form names in the Source MS Access database.
  1. Button to convert selected forms
  1. System Log

## Running from the command line ##
Syntax of Command line:

  1. ```
AccessDotNetConverter -form [formname] -configFile [configfile]``` Loads the config file specified in "configFile" parameter, and converts form name specified in parameter - form.
  1. ```
AccessDotNetConverter -form [formname] -sourceAccessDatabase [path to ms access database]``` Converts form name specified in parameter "form" from the access database specified in the "sourceAccessDatabase" parameter. The configuration file used is the [default configuration file](https://code.google.com/p/msaccess-subversion-control/source/browse/AccessSVNTool/trunk/AccessDotNetConverter/AccessToDotNetControlMap.xml) of the application