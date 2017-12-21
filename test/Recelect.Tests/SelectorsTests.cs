using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using static Recelect.Selectors;

namespace Recelect.Tests
{
    public class SelectorsTests
    {
        [Fact]
        public void CreateSelectorTest()
        {
            Func<AppState, IList<Item>> shopItemsSelector = (state) => state.Shop.Items;
            Func<AppState, double> taxPercentSelector = (state) => state.Shop.TaxPercent;

            var subtotalSelector = CreateSelector(shopItemsSelector, items =>
            {
                return items.Aggregate(0.0, (total, item) => total + item.Value);
            });

            var taxSelector = CreateSelector(subtotalSelector, taxPercentSelector, (subtotal, taxPercent) =>
            {
                return subtotal * (taxPercent / 100.0);
            });

            var totalSelector = CreateSelector(subtotalSelector, taxSelector, (subtotal, tax) =>
            {
                return subtotal + tax;
            });

            var exampleState = new AppState()
            {
                Shop = new Shop()
                {
                    TaxPercent = 8,
                    Items = new List<Item>()
                    {
                        new Item()
                        {
                            Name = "apple",
                            Value = 1.20,
                        },
                        new Item()
                        {
                            Name = "orange",
                            Value = 0.95,
                        },
                    },
                }
            };

            Assert.Equal(2.15, subtotalSelector(exampleState));
            Assert.Equal(0.172, taxSelector(exampleState));
            Assert.Equal(2.322, totalSelector(exampleState));
        }
    }

    class Item
    {
        public string Name { get; set; }

        public double Value { get; set; }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + Name.GetHashCode();
            hash = hash * 23 + Value.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (obj is Item other)
            {
                return Name == other.Name && Value == other.Value;
            }
            else
            {
                return false;
            }
        }
    }

    class Shop
    {
        public double TaxPercent { get; set; }

        public IList<Item> Items { get; set; } = new List<Item>();

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 + TaxPercent.GetHashCode();
            // TODO: Add items
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (obj is Shop other)
            {
                return TaxPercent == other.TaxPercent && Items == other.Items;
            }
            else
            {
                return false;
            }
        }
    }

    class AppState
    {
        public Shop Shop { get; set; }

        public override int GetHashCode()
        {
            var hash = 17;
            hash = hash * 23 * Shop.GetHashCode();
            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else if (ReferenceEquals(this, obj))
            {
                return true;
            }
            else if (obj is AppState other)
            {
                return Shop == other.Shop;
            }
            else
            {
                return false;
            }
        }
    }
}
