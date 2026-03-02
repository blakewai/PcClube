using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PCClub.Logic.SavePhoto
{
    class SaveImageToDataBase
    {
        public byte[] ConvertImageToByteArrayWithValidation(string filePath)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string fileExtension = Path.GetExtension(filePath).ToLower();

            if (!allowedExtensions.Contains(fileExtension))
            {
                throw new ArgumentException("Неподдерживаемый формат изображения");
            }

            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] imageData = new byte[fileStream.Length];
                    int bytesRead = fileStream.Read(imageData, 0, (int)fileStream.Length);

                    if (bytesRead != fileStream.Length)
                    {
                        throw new IOException("Не удалось прочитать весь файл");
                    }

                    return imageData;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при чтении файла: {ex.Message}", ex);
            }
        }

    }
}
