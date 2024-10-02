using Aspose.Words;

namespace DocumentConverter
{
    // Интерфейс для документа Word
    public interface IWordDocument
    {
        string GetWordContent();
    }

    // Класс, реализующий интерфейс IWordDocument
    public class WordDocument : IWordDocument
    {
        private readonly string _filePath;

        public WordDocument(string filePath)
        {
            _filePath = filePath;
        }

        public string GetWordContent()
        {
            // Считываем содержимое документа Word из файла
            try
            {
                return File.ReadAllText(_filePath);
            }
            catch (Exception e)
            {
                throw new IOException("Error reading Word document", e);
            }
        }
    }

    // Интерфейс для документа PDF
    public interface IPDFDocument
    {
        byte[] GetPDFContent();
    }

    // Адаптер для преобразования документа Word в PDF
    public class WordToPDFAdapter : IPDFDocument
    {
        private readonly IWordDocument _wordDocument;

        public WordToPDFAdapter(IWordDocument wordDocument)
        {
            _wordDocument = wordDocument;
        }

        public byte[] GetPDFContent()
        {
            // Получаем содержимое документа Word
            string wordContent = _wordDocument.GetWordContent();

            // Создаем поток для записи PDF
            using (MemoryStream outputStream = new MemoryStream())
            {
                // Создаем новый документ Word и загружаем в него содержимое
                Aspose.Words.Document doc = new Aspose.Words.Document();
                DocumentBuilder builder = new DocumentBuilder(doc);
                builder.Write(wordContent);

                // Сохраняем документ Word в поток в формате PDF
                doc.Save(outputStream, SaveFormat.Pdf);

                // Возвращаем массив байтов с содержимым PDF
                return outputStream.ToArray();
            }
        }
    }

    class Adapter
    {
        static void main(string[] args)
        {
            // Путь к файлу Word
            string filePath = "D:\\ucioba\\TMPPP\\test.docx";

            // Создаем объект для работы с файлом в формате Word
            IWordDocument wordDocument = new WordDocument(filePath);

            // Создаем адаптер для работы с файлом в формате Word через интерфейс PDFDocument
            IPDFDocument pdfDocument = new WordToPDFAdapter(wordDocument);

            try
            {
                // Вывод содержимого файла в формате PDF через адаптер
                DisplayPDFContent(pdfDocument);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error converting document: " + e.Message);
            }
        }

        // Функция для вывода содержимого PDF документа
        static void DisplayPDFContent(IPDFDocument pdfDocument)
        {
            // Получаем содержимое PDF документа
            byte[] pdfContent = pdfDocument.GetPDFContent();
            Console.WriteLine("PDF Content:\n" + Convert.ToBase64String(pdfContent));
        }
    }
}
