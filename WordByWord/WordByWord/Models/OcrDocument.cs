﻿using System.IO;
using GalaSoft.MvvmLight;

namespace WordByWord.Models
{
    public class OcrDocument : ObservableObject
    {
        private string _filePath;
        private string _ocrText = string.Empty;
        private bool _isBusy = true;
        private string _fileName;

        public OcrDocument() { }

        public OcrDocument(string filePath)
        {
            _filePath = filePath;
            _fileName = Path.GetFileName(filePath);
        }

        public string FilePath
        {
            get => _filePath;
            set { Set(() => FilePath, ref _filePath, value); }
        }

        public string FileName
        {
            get => _fileName;
            set { Set(() => FileName, ref _fileName, value); }
        }

        public string OcrText
        {
            get => _ocrText;
            set
            {
                Set(() => OcrText, ref _ocrText, value);
                IsBusy = false;
            }
        }

        public bool IsBusy
        {
            get => _isBusy;
            set { Set(() => IsBusy, ref _isBusy, value); }
        }
    }
}
