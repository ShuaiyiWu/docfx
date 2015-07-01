﻿namespace Microsoft.DocAsCode.BackEnd.Tests
{
    using EntityModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    [Trait("Owner", "vwxyzh")]
    [Trait("EntityType", "ViewModel")]
    public class ConvertToViewModelUnitTest
    {
        #region Data

        private readonly MetadataItem model = new MetadataItem
        {
            Type = MemberType.Assembly,
            Items = new List<MetadataItem>
            {
                new MetadataItem
                {
                    Name = "N1",
                    Type = MemberType.Namespace,
                    DisplayNames = new SortedList<SyntaxLanguage, string>
                    {
                        { SyntaxLanguage.CSharp, "N1" },
                        { SyntaxLanguage.VB, "N1" },
                    },
                    DisplayQualifiedNames = new SortedList<SyntaxLanguage, string>()
                    {
                        { SyntaxLanguage.CSharp, "N1" },
                        { SyntaxLanguage.VB, "N1" },
                    },
                    References = new Dictionary<string, ReferenceItem>
                    {
                        {
                            "N1.C1",
                            new ReferenceItem
                            {
                                IsDefinition = true,
                                Type = MemberType.Class,
                                Parent = "N1",
                                Summary = "Summary!",
                                Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                {
                                    {
                                        SyntaxLanguage.CSharp,
                                        new List<LinkItem>
                                        {
                                            new LinkItem
                                            {
                                                DisplayName = "C1",
                                                DisplayQualifiedNames = "N1.C1",
                                                Name = "N1.C1",
                                                IsExternalPath = false,
                                                Href = "href!",
                                            }
                                        }
                                    },
                                    {
                                        SyntaxLanguage.VB,
                                        new List<LinkItem>
                                        {
                                            new LinkItem
                                            {
                                                DisplayName = "C1",
                                                DisplayQualifiedNames = "N1.C1",
                                                Name = "N1.C1",
                                                IsExternalPath = false,
                                                Href = "href!",
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    Items = new List<MetadataItem>
                    {
                        new MetadataItem
                        {
                            Name = "N1.C1",
                            Type = MemberType.Class,
                            DisplayNames = new SortedList<SyntaxLanguage, string>
                            {
                                { SyntaxLanguage.CSharp, "C1" },
                                { SyntaxLanguage.VB, "C1" },
                            },
                            DisplayQualifiedNames = new SortedList<SyntaxLanguage, string>()
                            {
                                { SyntaxLanguage.CSharp, "N1.C1" },
                                { SyntaxLanguage.VB, "N1.C1" },
                            },
                            Inheritance = new List<string>
                            {
                                "System.Object",
                                "System.Collections.Generic.List{System.Object}",
                            },
                            Implements = new List<string>
                            {
                                "System.Collections.Generic.IList{System.Object}",
                                "System.Collections.Generic.ICollection{System.Object}",
                                "System.Collections.Generic.IEnumerable{System.Object}",
                                "System.Collections.IEnumerable",
                            },
                            InheritedMembers = new List<string>
                            {
                                "System.Object.GetHashCode",
                            },
                            References = new Dictionary<string, ReferenceItem>
                            {
                                {
                                    "System",
                                    new ReferenceItem
                                    {
                                        IsDefinition = true,
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "System",
                                                        DisplayQualifiedNames= "System",
                                                        Name = "System",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "System",
                                                        DisplayQualifiedNames= "System",
                                                        Name = "System",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                        }
                                    }
                                },
                                {
                                    "System.Collections.Generic",
                                    new ReferenceItem
                                    {
                                        IsDefinition = true,
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "System.Collections.Generic",
                                                        DisplayQualifiedNames= "System.Collections.Generic",
                                                        Name = "System.Collections.Generic",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "System.Collections.Generic",
                                                        DisplayQualifiedNames= "System.Collections.Generic",
                                                        Name = "System.Collections.Generic",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                        }
                                    }
                                },
                                {
                                    "System.Object",
                                    new ReferenceItem
                                    {
                                        IsDefinition = true,
                                        Parent = "System",
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "Object",
                                                        DisplayQualifiedNames= "System.Object",
                                                        Name = "System.Object",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "Object",
                                                        DisplayQualifiedNames= "System.Object",
                                                        Name = "System.Object",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    "System.Object.GetHashCode",
                                    new ReferenceItem
                                    {
                                        IsDefinition = true,
                                        Parent = "System.Object",
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "GetHashCode()",
                                                        DisplayQualifiedNames= "System.Object.GetHashCode()",
                                                        Name = "System.Object.GetHashCode",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "GetHashCode()",
                                                        DisplayQualifiedNames= "System.Object.GetHashCode()",
                                                        Name = "System.Object.GetHashCode",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    "System.Collections.Generic.List`1",
                                    new ReferenceItem
                                    {
                                        IsDefinition = true,
                                        Parent = "System.Collections.Generic",
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "List<T>",
                                                        DisplayQualifiedNames = "System.Collections.Generic.List<T>",
                                                        Name = "System.Collections.Generic.List`1",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "List(Of T)",
                                                        DisplayQualifiedNames = "System.Collections.Generic.List(Of T)",
                                                        Name = "System.Collections.Generic.List`1",
                                                        IsExternalPath = true,
                                                    }
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    "System.Collections.Generic.List{System.Object}",
                                    new ReferenceItem
                                    {
                                        IsDefinition = false,
                                        Definition = "System.Collections.Generic.List`1",
                                        Parent = "System.Collections.Generic",
                                        Parts = new Dictionary<SyntaxLanguage, List<LinkItem>>
                                        {
                                            {
                                                SyntaxLanguage.CSharp,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "List",
                                                        DisplayQualifiedNames = "System.Collections.Generic.List",
                                                        Name = "System.Collections.Generic.List`1",
                                                        IsExternalPath = true
                                                    },
                                                    new LinkItem { DisplayName = "<", DisplayQualifiedNames = "<" },
                                                    new LinkItem
                                                    {
                                                        DisplayName = "Object",
                                                        DisplayQualifiedNames = "System.Object",
                                                        Name = "System.Object",
                                                        IsExternalPath = true
                                                    },
                                                    new LinkItem { DisplayName = ">", DisplayQualifiedNames = ">" },
                                                }
                                            },
                                            {
                                                SyntaxLanguage.VB,
                                                new List<LinkItem>
                                                {
                                                    new LinkItem
                                                    {
                                                        DisplayName = "List",
                                                        DisplayQualifiedNames = "System.Collections.Generic.List",
                                                        Name = "System.Collections.Generic.List`1",
                                                        IsExternalPath = true,
                                                    },
                                                    new LinkItem { DisplayName = "(Of ", DisplayQualifiedNames = "(Of " },
                                                    new LinkItem
                                                    {
                                                        DisplayName = "Object",
                                                        DisplayQualifiedNames = "System.Object",
                                                        Name = "System.Object",
                                                        IsExternalPath = true,
                                                    },
                                                    new LinkItem { DisplayName = ")", DisplayQualifiedNames = ")" },
                                                }
                                            },
                                        },
                                    }
                                },
                            }
                        },
                    }
                }
            },
        };

        #endregion

        [Trait("Related", "Reference")]
        [Fact]
        public void TestConvertNamespace()
        {
            var vm = OnePageViewModel.Convert(model.Items[0]);
            Assert.NotNull(vm);
            Assert.True(vm.Items[0].ContainsKey("children"));
            var children = (IEnumerable<string>)vm.Items[0]["children"];
            Assert.NotNull(children);
            Assert.Equal(1, children.Count());

            Assert.NotNull(vm.References);
            Assert.Equal(1, vm.References.Count);

            var reference = vm.References.Find(x => x["uid"] as string == "N1.C1");
            Assert.NotNull(reference);
            Assert.Equal("Class", reference["type"]);
            Assert.Equal("Summary!", reference["summary"]);
            Assert.Equal("C1", reference["name.csharp"]);
            Assert.Equal("C1", reference["name.vb"]);
            Assert.Equal("N1.C1", reference["fullName.csharp"]);
            Assert.Equal("N1.C1", reference["fullName.vb"]);
            Assert.False((bool)reference["isExternal"]);
            Assert.Equal("href!", reference["href"]);
        }

        [Trait("Related", "Generic")]
        [Trait("Related", "Reference")]
        [Fact]
        public void TestConvertType()
        {
            var vm = OnePageViewModel.Convert(model.Items[0].Items[0]);
            Assert.NotNull(vm);
            Assert.False(vm.Items[0].ContainsKey("children"));
            Assert.True(vm.Items[0].ContainsKey("inheritance"));
            var inheritance = (IEnumerable<string>)vm.Items[0]["inheritance"];
            Assert.NotNull(inheritance);
            Assert.Equal(2, inheritance.Count());
            Assert.Equal(new[] { "System.Object", "System.Collections.Generic.List{System.Object}" }, inheritance.ToList());

            var implements = (IEnumerable<string>)vm.Items[0]["implements"];
            Assert.NotNull(implements);
            Assert.Equal(
                new[]
                {
                        "System.Collections.Generic.IList{System.Object}",
                        "System.Collections.Generic.ICollection{System.Object}",
                        "System.Collections.Generic.IEnumerable{System.Object}",
                        "System.Collections.IEnumerable",
                }.OrderBy(s => s),
                implements.OrderBy(s => s));

            Assert.True(vm.Items[0].ContainsKey("inheritedMembers"));
            var inheritedMembers = (IEnumerable<string>)vm.Items[0]["inheritedMembers"];
            Assert.NotNull(inheritedMembers);
            Assert.Equal(1, inheritedMembers.Count());
            Assert.Equal(new[] { "System.Object.GetHashCode" }, inheritedMembers.ToList());

            Assert.NotNull(vm.References);
            Console.WriteLine(string.Join(";", from r in vm.References select (string)r["uid"]));
            Assert.Equal(
                new[]
                {
                        "System",
                        "System.Collections.Generic",
                        "System.Object",
                        "System.Object.GetHashCode",
                        "System.Collections.Generic.List`1",
                        "System.Collections.Generic.List{System.Object}"
                },
                (from r in vm.References select (string)r["uid"]).ToList());

            var reference = vm.References.Find(x => x["uid"] as string == "System.Object");
            Assert.NotNull(reference);
            Assert.Equal("Object", reference["name.csharp"]);
            Assert.Equal("Object", reference["name.vb"]);
            Assert.Equal("System.Object", reference["fullName.csharp"]);
            Assert.Equal("System.Object", reference["fullName.vb"]);
            Assert.Equal(true, reference["isExternal"]);
            Assert.Equal("System", reference["parent"]);
            Assert.False(reference.ContainsKey("href"));

            reference = vm.References.Find(x => x["uid"] as string == "System.Object.GetHashCode");
            Assert.NotNull(reference);
            Assert.Equal("GetHashCode()", reference["name.csharp"]);
            Assert.Equal("GetHashCode()", reference["name.vb"]);
            Assert.Equal("System.Object.GetHashCode()", reference["fullName.csharp"]);
            Assert.Equal("System.Object.GetHashCode()", reference["fullName.vb"]);
            Assert.Equal(true, reference["isExternal"]);
            Assert.Equal("System.Object", reference["parent"]);
            Assert.False(reference.ContainsKey("href"));

            reference = vm.References.Find(x => x["uid"] as string == "System.Collections.Generic.List{System.Object}");
            Assert.NotNull(reference);
            {
                Assert.Equal("List<Object>", reference["name.csharp"]);
                Assert.Equal("System.Collections.Generic.List<System.Object>", reference["fullName.csharp"]);
                var list = reference["spec.csharp"] as List<ItemViewModel>;
                Assert.NotNull(list);
                Assert.Equal(new[] { "List", "<", "Object", ">" }, (from x in list select (string)x["name"]).ToList());
                Assert.Equal(new[] { "System.Collections.Generic.List", "<", "System.Object", ">" }, (from x in list select (string)x["fullName"]).ToList());
                Assert.Equal("System.Collections.Generic.List`1", list[0]["uid"]);
                Assert.False(list[1].ContainsKey("uid"));
                Assert.Equal("System.Object", list[2]["uid"]);
                Assert.False(list[3].ContainsKey("uid"));
                Assert.Equal(true, list[0]["isExternal"]);
                Assert.False(list[1].ContainsKey("isExternal"));
                Assert.Equal(true, list[2]["isExternal"]);
                Assert.False(list[3].ContainsKey("isExternal"));
                Assert.False(list[0].ContainsKey("href"));
                Assert.False(list[1].ContainsKey("href"));
                Assert.False(list[2].ContainsKey("href"));
                Assert.False(list[3].ContainsKey("href"));
            }
            {
                Assert.Equal("List(Of Object)", reference["name.vb"]);
                Assert.Equal("System.Collections.Generic.List(Of System.Object)", reference["fullName.vb"]);
                var list = reference["spec.vb"] as List<ItemViewModel>;
                Assert.NotNull(list);
                Assert.Equal(new[] { "List", "(Of ", "Object", ")" }, (from x in list select (string)x["name"]).ToList());
                Assert.Equal(new[] { "System.Collections.Generic.List", "(Of ", "System.Object", ")" }, (from x in list select (string)x["fullName"]).ToList());
                Assert.Equal("System.Collections.Generic.List`1", list[0]["uid"]);
                Assert.False(list[1].ContainsKey("uid"));
                Assert.Equal("System.Object", list[2]["uid"]);
                Assert.False(list[3].ContainsKey("uid"));
                Assert.Equal(true, list[0]["isExternal"]);
                Assert.False(list[1].ContainsKey("isExternal"));
                Assert.Equal(true, list[2]["isExternal"]);
                Assert.False(list[3].ContainsKey("isExternal"));
                Assert.False(list[0].ContainsKey("href"));
                Assert.False(list[1].ContainsKey("href"));
                Assert.False(list[2].ContainsKey("href"));
                Assert.False(list[3].ContainsKey("href"));
            }
            Assert.Equal("System.Collections.Generic.List`1", reference["definition"]);
            Assert.Equal("System.Collections.Generic", reference["parent"]);
            Assert.False(reference.ContainsKey("isExternal"));
            Assert.False(reference.ContainsKey("href"));

            Assert.True(vm.References.Any(x => x["uid"] as string == "System.Collections.Generic.List`1"));
        }

    }
}
