set output_dir=%1
set solution_dir=%2
set ilmerge=%solution_dir%..\lib\ilmerge\ILMerge.exe

copy DrDoc.exe temp.exe
call %ilmerge% /Out:DrDoc2.exe temp.exe Spark.dll SparkLanguage.dll Interop.SparkLanguagePackageLib.dll
del temp.exe
del Spark.dll
del SparkLanguage.dll
del Interop.SparkLanguagePackageLib.dll