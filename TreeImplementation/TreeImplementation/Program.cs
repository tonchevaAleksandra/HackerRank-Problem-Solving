using System;
using System.Collections.Generic;

namespace BasicTreeImplementation
{
  public  class Program
    {
        static void Main(string[] args)
        {
            ImplementTreeOfIntegerValues();

            Tree<Person> company = new Tree<Person>();
            company.Root = new TreeNode<Person>()
            {
                Data = new Person() {Id = 100, Name = "Marcin Jamro", Role = "CEO"},
                Parent = null
            };

            company.Root.Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person() {Id = 1, Name = "John Smith", Role = "Head of Development"},
                    Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person() {Id = 50, Name = "Mary Fox", Role = "Head of Research"}, Parent = company.Root
                },
                new TreeNode<Person>()
                {
                    Data = new Person() {Id = 150, Name = "Lilly Smith", Role = "Head of Sales"}, Parent = company.Root
                },
            };

            company.Root.Children[2].Children = new List<TreeNode<Person>>()
            {
                new TreeNode<Person>()
                {
                    Data = new Person()
                    {
                        Id = 15, Name = "Emilie Summer", Role = "Team Lead"
                    },
                    Parent = company.Root.Children[2]
                }
            };
        }

        private static void ImplementTreeOfIntegerValues()
        {
            Tree<int> tree = new Tree<int>();
            tree.Root = new TreeNode<int>() {Data = 10};
            tree.Root.Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>() {Data = 50, Parent = tree.Root},
                new TreeNode<int>() {Data = 1, Parent = tree.Root},
                new TreeNode<int>() {Data = 150, Parent = tree.Root},
            };

            tree.Root.Children[2].Children = new List<TreeNode<int>>()
            {
                new TreeNode<int>() {Data = 30, Parent = tree.Root.Children[2]}
            };
        }
    }
}
