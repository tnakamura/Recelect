# Recelect

Selector library for Redux in C# - Inspired by reselect


## Install

First, [install Nuget](http://docs.nuget.org/docs/start-here/installing-nuget).
Then, install [Recelect](http://www.nuget.org/packages/Recelect) from the package manager console:

```
PM> Install-Package Recelect
```


## Usage

Define your state.

```c#
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
```

A few selectors:

```c#
Func<AppState, IList<Item>> shopItemsSelector = (state) => state.Shop.Items;
Func<AppState, double> taxPercentSelector = (state) => state.Shop.TaxPercent;

var subtotalSelector = Selectors.CreateSelector(shopItemsSelector, items =>
{
    return items.Aggregate(0.0, (total, item) => total + item.Value);
});

var taxSelector = Selectors.CreateSelector(subtotalSelector, taxPercentSelector, (subtotal, taxPercent) =>
{
    return subtotal * (taxPercent / 100.0);
});

var totalSelector = Selectors.CreateSelector(subtotalSelector, taxSelector, (subtotal, tax) =>
{
    return subtotal + tax;
});
```

Using the selectors:

```c#
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
```

## Contribution

1. Fork it
2. Create your feature branch ( git checkout -b my-new-feature )
3. Commit your changes ( git commit -am 'Add some feature' )
4. Push to the branch ( git push origin my-new-feature )
5. Create new Pull Request


## License

[MIT](https://opensource.org/licenses/MIT)


## Author

[tnakamura](https://github.com/tnakamura)

