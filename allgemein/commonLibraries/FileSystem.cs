using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace commonLibraries
{
    internal class FileSystem
    {
        string path;

        internal FileSystem(string path)
        {
            this.path = path;
        }
        internal FileSystem()
        {

        }

        internal string getExtension(string path = "")
        {
            string extension = "";
            string filestring;
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            int start = filestring.LastIndexOf('.');
            extension = filestring.Substring(start + 1);

            return extension;
        }
        internal string getFileNamewithoutExtension(string path = "")
        {
            int length = 0;
            int start = 0;
            string filestring;
            string fileName = "";
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            start = filestring.LastIndexOf('\\');
            length = filestring.LastIndexOf('.') - start;
            fileName = filestring.Substring(start, length);
            return fileName;

        }
        internal string getFilename(string path = "")
        {

            int start = 0;
            string filestring;
            string fileName = "";
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            start = filestring.LastIndexOf('\\');
            fileName = filestring.Substring(start);
            return fileName;
        }
        internal string getPathToFile(string path = "")
        {
            int length = 0;
            string filestring;
            string folder = "";
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            length = filestring.LastIndexOf('\\');
            folder = filestring.Substring(0, length);
            return folder;
        }
        internal List<string> getAllSubFolders(string path = "")
        {
            List<string> folders = new List<string>();
            string filestring;

            string[] temp;
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            foreach (string folder in Directory.GetDirectories(filestring))
            {
                temp = folder.Split('\\');
                folders.Add(temp.Last());
            }
            return folders;
        }
        internal List<KeyValuePair<string, string>> getAllSubfoldersWithPath(string path = "")
        {
            List<KeyValuePair<string, string>> folders = new List<KeyValuePair<string, string>>();
            string filestring;

            string[] temp;
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            foreach (string folder in Directory.GetDirectories(filestring))
            {
                temp = folder.Split('\\');
                folders.Add(new KeyValuePair<string, string>(temp.Last(), folder));
            }
            return folders;
        }

        internal List<string> GetAllFilesInDirectory(string path = "")
        {
            List<string> files = new List<string>();
            string[] temp;
            string filestring;
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            foreach (string file in Directory.GetFiles(filestring))
            {
                temp = file.Split('\\');
                files.Add(temp.Last());
            }
            return files;
        }
        internal List<string> getDirectoryTree(string path = "",bool listSubfolders=false)
        {
            string filestring = "";
            List<string> files = new List<string>();
            if (path == "")
            {
                filestring = this.path;
            }
            else
            {
                filestring = path;
            }
            foreach (string file in Directory.GetFiles(filestring))
            {
                files.Add(file);
            }
            foreach (string folder in Directory.GetDirectories(filestring))
            {
                foreach (string subfolder in Directory.GetDirectories(folder))
                {
                    if(listSubfolders) files.Add(subfolder);
                    foreach (string file in Directory.GetFiles(folder))
                    {
                        files.Add(file);
                    }
                    foreach (string file in Directory.GetFiles(subfolder))
                    {
                        files.Add(file);
                    }
                }
            }

            return files;
        }
        internal void setFileAtributes(FileAttributes setting, string filePath="")
        {
            try
            {
                File.SetAttributes(filePath, setting);
            }
            catch
            {

            }
        }
        internal void setFileAtributesRecursive(FileAttributes setting, string filePath="")
        {
            List<string> allFiles = getDirectoryTree(filePath);
            foreach (string entry in allFiles)
            {

                setFileAtributes(setting, entry);
            }
        }
        internal DateTime getFileCreationTime(string filepath="")
        {
            if (filepath == "") filepath = this.path;
            return File.GetCreationTime(filepath);
        }
        internal string getNewestFileInFolder(string folder="")
        {
            string newestFile = "";
            DateTime puffer=DateTime.MinValue;
            if (folder == "") folder = this.path;
            List<string> filesInFolder = GetAllFilesInDirectory(folder);
            foreach(string file in filesInFolder)
            {
                if(getFileCreationTime(file)>puffer)
                {
                    puffer = getFileCreationTime(file);
                    newestFile = file;
                }
            }
            return newestFile;
        }
        internal string getParentFolder(string path="")
        {
            string parent = "";
            if (path == "") path = this.path;
            string[] parts = path.Split('\\');
            parent = parts[parts.Count() - 1];
            return parent;
        }
        internal void copyFolderStructure(string source, string dest)
        {
            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }
            copyfiles(source, dest);
            foreach (string subdir in getAllSubFolders(source))
            {
                string fullSubdir = source + "\\" + subdir;
                string fullDestDir = dest + "\\" + subdir;
                if (!Directory.Exists(fullDestDir))
                {
                    Directory.CreateDirectory(fullDestDir);
                }
                copyfiles(fullSubdir, dest + "\\" + subdir);
                foreach (string subdir2 in getAllSubFolders(fullSubdir))
                {
                    string fullSubdir2 = fullSubdir + "\\" + subdir2;
                    if (!Directory.Exists(fullDestDir + "\\" + subdir2))
                    {
                        Directory.CreateDirectory(fullDestDir + "\\" + subdir2);
                    }
                    copyfiles(fullSubdir2, fullDestDir + "\\" + subdir2);
                }
            }
        }
        private void copyfiles(string sourcePath, string destpath)
        {
            foreach (string file in GetAllFilesInDirectory(sourcePath))
            {
                File.Copy(sourcePath + "\\" + file, destpath + "\\" + file, true);
            }
        }
    }
}
