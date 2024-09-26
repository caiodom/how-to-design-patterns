using TemplateMethod;

FileProcessor txtFile = new TextFileProcessor();
txtFile.Template();

FileProcessor csvFile= new CsvFileProcessor();
csvFile.Template();

FileProcessor xmlFile=new XmlFileProcessor();
xmlFile.Template();