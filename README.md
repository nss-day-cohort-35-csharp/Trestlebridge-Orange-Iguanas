![trestlebridge farm landscape](./TrestlebridgeFarms.png)

# Trestlebridge Farm - Orange Iguanas

The goal of this group project, was to learn. We chose to have fun with this code, make lots of mistakes, refactor them, and learn about what we can do with C#.

We have decided to connect with the earth again and abandon our reliance on technology and urban vices. We have built a business plan, presented it to a bank, and have secured \$5 million to purchase an abandoned farm and produce high quality, responsibly grown and raised meat, seed, eggs, feathers and compost.

We have met with other growers and ranchers in the Middle Tennessee area and have decided on the animals and plants below to build our farm. For each resource, we found where it will be stored on the farm, what is produced, when it is processed, and how much it produces.

## Group Members

Seth Oakley[github.com](https://github.com/sethoak)

Lauren Maxwell[github.com](https://github.com/laurenelizamax)

David Cornish[github.com](https://github.com/dcornish84)

Mark McCann[github.com](ttps://github.com/mjmccann90)

## Setup: Please follow these steps

1. Clone repo
2. cd into the src folder
3. To run the program type dotnet run

### Main Menu

Fancy web applications are so 2017. Command line applications provide a much more hands-on, personal, bespoke, artisinal experience when managing a farm such as Trestlebridge. Therefore, even though you are casting off your digital personas to lead a life connected with the land, you still want to use your hard-earned skills as developers to make management of your farm as efficient as possible.

Here are the main features that the application must be able to perform.

When the user first executes FARMS, they should be welcomed to the system and be presented with the following menu.

```sh
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
 |T||r||e||s||t||l||e||b||r||i||d||g||e|
 +-++-++-++-++-++-++-++-++-++-++-++-++-+
           |F||a||r||m||s|
           +-++-++-++-++-+

1. Create Facility
2. Purchase Animals
3. Purchase Seeds
4. Processing Options (this is a stretch goal)

Choose a FARMS option.
> _
```

### Facility Creation Options Sub-Menu

If the user chooses option 1, then the following menu should be displayed

```sh
1. Grazing field
2. Plowed field
3. Natural field
4. Chicken house
5. Duck house

Choose what you want to create.
> _
```

When the user makes a choice, a new instance of that type of facility should be added to a `List<>` on your farm.

### Animal Purchase Menu

If the user chooses 2 from the main menu, then she should see the following menu, with the animals listed in alphabetical order.

```sh
1. Chicken
2. Cow
3. Duck
4. Goat
5. Ostrich
6. Pig
7. Sheep

Choose animals to purchase.
> _
```

When the user enters in what to buy, then display all of the locations in which the animals can be stored. The current number of animals should be displayed for each location.

```sh
1. Grazing Field (16 animals)
2. Grazing Field (4 animals)

Where would you like to place the animals?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Grazing Field (16 animals)
2. Grazing Field (4 animals)

Where would you like to place the animals?
> _
```

### Seed Purchase Menu

If the user chooses 3 from the main menu, then she should see the following menu, with the plants listed in alphabetical order. You purchase enough seeds for an entire row at a time.

```sh
1. Sesame
2. Sunflower
3. Wildflower

Choose seed to purchase.
> _
```

When the user makes a choice, then display all of the locations in which the plants can be planted. The current number of plant rows should be displayed for each location.

```sh
1. Plowed Field (8 rows of plants)
2. Plowed Field (5 rows of plants)
3. Natural Field (0 rows of plants)

Where would you like to plant the Sunflowers?
> _
```

If the user chose to place them in a location that would be over capacity if they were placed there, display a message and show the menu again.

```sh
**** That facililty is not large enough ****
****     Please choose another one      ****

1. Plowed Field (8 rows of plants)
2. Plowed Field (5 rows of plants)
3. Natural Field (0 rows of plants)

Where would you like to plant the Sunflowers?
> _
```
