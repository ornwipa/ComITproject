using System;
using System.Linq;
using System.Text;
using TinyCsvParser;
using System.Collections.Generic;

namespace recommender.Models
{
    public class TinyCsvParserBook
    {
        public static Book[] ReadBookCsv()
        {
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            CsvReaderOptions csvReaderOptions = new CsvReaderOptions(new[] { Environment.NewLine });
            CsvBookMapping csvMapper = new CsvBookMapping();
            CsvParser<Book> csvParser = new CsvParser<Book>(csvParserOptions, csvMapper);
            // var record = csvParser.ReadFromFile("../data_source/books.csv", Encoding.UTF8).ToList();
            var record = csvParser.ReadFromFile("Data/books.csv", Encoding.UTF8).ToList();
            return record.Select(x => x.Result).ToArray();
        }
    }
}