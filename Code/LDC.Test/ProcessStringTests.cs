using System;
using System.Collections.Generic;
using Xunit;

namespace LDC.Test
{
    public class ProcessStringTests
    {
        ProcessString _ps = new ProcessString();

        [Fact]
        public void Should_return_exception_for_empty_input_list()
        {
            // giving
            List<string> inputL = new List<string>();

            //then
            var ex = Assert.Throws<ArgumentException>(() => _ps.Process(inputL));
            Assert.Equal("List should not be empty", ex.Message);
        }

        [Fact]
        public void Should_return_exception_input_list_contains_empty_string()
        {
            // giving
            List<string> inputL = new List<string>()
            {
                "",
                "abc"
            };

            //then
            var ex = Assert.Throws<ArgumentException>(() => _ps.Process(inputL));
            Assert.Equal("List contains empty string", ex.Message);
        }

        [Fact]
        public void Should_throw_exception_when_input_list_contains_null_string()
        {
            // giving
            List<string> inputL = new List<string>()
            {
                null,
                "abc"
            };

            //then
            var ex = Assert.Throws<ArgumentException>(() => _ps.Process(inputL));
            Assert.Equal("List contains empty string", ex.Message);
        }
        [Fact]
        public void Should_throw_exception_when_input_list_contains_empty_string()
        {
            // giving
            List<string> inputL = new List<string>()
            {
                "   ",
                "abc"
            };

            //then
            var ex = Assert.Throws<ArgumentException>(() => _ps.Process(inputL));
            Assert.Equal("List contains empty string", ex.Message);
        }

        [Fact]
        public void Should_return_correct_string_manipulated()
        {
            // giving
            List<string> inputL = new List<string>()
            {
                "AAAc5fggyyyy4$$$$$$££___gdsuyeybdxkkkkassys"
            };

            var actual = _ps.Process(inputL);

            //then
            List<string> expected = new List<string>()
            {
                "Ac5fgy££gdsuyey"
            };

            Assert.Single(actual);
            Assert.Equal(expected[0], actual[0]);
            Assert.Equal(expected[0].Length, actual[0].Length);

        }

        [Fact]
        public void Should_throw_exception_when_processed_string_result_empty()
        {
            // giving
            List<string> inputL = new List<string>()
            {
                "444___"
            };

            //then
            var ex = Assert.Throws<ArgumentException>(() => _ps.Process(inputL));
            Assert.Equal("String is empty", ex.Message);
        }



    }
}
