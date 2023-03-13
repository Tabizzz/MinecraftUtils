namespace Org.Bukkit;

public enum Material
{
	//<editor-fold desc="Materials" defaultstate="collapsed">
	AIR= 9648,
	STONE= 22948,
	GRANITE= 21091,
	POLISHED_GRANITE= 5477,
	DIORITE= 24688,
	POLISHED_DIORITE= 31615,
	ANDESITE= 25975,
	POLISHED_ANDESITE= 8335,
	/**
	 * BlockData: {@link Orientable}
	 */
	DEEPSLATE= 26842,
	COBBLED_DEEPSLATE= 8021,
	POLISHED_DEEPSLATE= 31772,
	CALCITE= 20311,
	TUFF= 24364,
	DRIPSTONE_BLOCK= 26227,
	/**
	 * BlockData: {@link Snowable}
	 */
	GRASS_BLOCK= 28346,
	DIRT= 10580,
	COARSE_DIRT= 15411,
	/**
	 * BlockData: {@link Snowable}
	 */
	PODZOL= 24068,
	ROOTED_DIRT= 11410,
	CRIMSON_NYLIUM= 18139,
	WARPED_NYLIUM= 26396,
	COBBLESTONE= 32147,
	OAK_PLANKS= 14905,
	SPRUCE_PLANKS= 14593,
	BIRCH_PLANKS= 29322,
	JUNGLE_PLANKS= 26445,
	ACACIA_PLANKS= 31312,
	DARK_OAK_PLANKS= 20869,
	CRIMSON_PLANKS= 18812,
	WARPED_PLANKS= 16045,
	/**
	 * BlockData: {@link Sapling}
	 */
	OAK_SAPLING= 9636,
	/**
	 * BlockData: {@link Sapling}
	 */
	SPRUCE_SAPLING= 19874,
	/**
	 * BlockData: {@link Sapling}
	 */
	BIRCH_SAPLING= 31533,
	/**
	 * BlockData: {@link Sapling}
	 */
	JUNGLE_SAPLING= 17951,
	/**
	 * BlockData: {@link Sapling}
	 */
	ACACIA_SAPLING= 20806,
	/**
	 * BlockData: {@link Sapling}
	 */
	DARK_OAK_SAPLING= 14933,
	BEDROCK= 23130,
	SAND= 11542,
	RED_SAND= 16279,
	GRAVEL= 7804,
	COAL_ORE= 30965,
	DEEPSLATE_COAL_ORE= 16823,
	IRON_ORE= 19834,
	DEEPSLATE_IRON_ORE= 26021,
	COPPER_ORE= 32666,
	DEEPSLATE_COPPER_ORE= 6588,
	GOLD_ORE= 32625,
	DEEPSLATE_GOLD_ORE= 13582,
	/**
	 * BlockData: {@link Lightable}
	 */
	REDSTONE_ORE= 10887,
	/**
	 * BlockData: {@link Lightable}
	 */
	DEEPSLATE_REDSTONE_ORE= 6331,
	EMERALD_ORE= 16630,
	DEEPSLATE_EMERALD_ORE= 5299,
	LAPIS_ORE= 22934,
	DEEPSLATE_LAPIS_ORE= 13598,
	DIAMOND_ORE= 9292,
	DEEPSLATE_DIAMOND_ORE= 17792,
	NETHER_GOLD_ORE= 4185,
	NETHER_QUARTZ_ORE= 4807,
	ANCIENT_DEBRIS= 18198,
	COAL_BLOCK= 27968,
	RAW_IRON_BLOCK= 32210,
	RAW_COPPER_BLOCK= 17504,
	RAW_GOLD_BLOCK= 23246,
	AMETHYST_BLOCK= 18919,
	BUDDING_AMETHYST= 13963,
	IRON_BLOCK= 24754,
	COPPER_BLOCK= 12880,
	GOLD_BLOCK= 27392,
	DIAMOND_BLOCK= 5944,
	NETHERITE_BLOCK= 6527,
	EXPOSED_COPPER= 28488,
	WEATHERED_COPPER= 19699,
	OXIDIZED_COPPER= 19490,
	CUT_COPPER= 32519,
	EXPOSED_CUT_COPPER= 18000,
	WEATHERED_CUT_COPPER= 21158,
	OXIDIZED_CUT_COPPER= 5382,
	/**
	 * BlockData: {@link Stairs}
	 */
	CUT_COPPER_STAIRS= 25925,
	/**
	 * BlockData: {@link Stairs}
	 */
	EXPOSED_CUT_COPPER_STAIRS= 31621,
	/**
	 * BlockData: {@link Stairs}
	 */
	WEATHERED_CUT_COPPER_STAIRS= 5851,
	/**
	 * BlockData: {@link Stairs}
	 */
	OXIDIZED_CUT_COPPER_STAIRS= 25379,
	/**
	 * BlockData: {@link Slab}
	 */
	CUT_COPPER_SLAB= 28988,
	/**
	 * BlockData: {@link Slab}
	 */
	EXPOSED_CUT_COPPER_SLAB= 26694,
	/**
	 * BlockData: {@link Slab}
	 */
	WEATHERED_CUT_COPPER_SLAB= 4602,
	/**
	 * BlockData: {@link Slab}
	 */
	OXIDIZED_CUT_COPPER_SLAB= 29642,
	WAXED_COPPER_BLOCK= 14638,
	WAXED_EXPOSED_COPPER= 27989,
	WAXED_WEATHERED_COPPER= 5960,
	WAXED_OXIDIZED_COPPER= 25626,
	WAXED_CUT_COPPER= 11030,
	WAXED_EXPOSED_CUT_COPPER= 30043,
	WAXED_WEATHERED_CUT_COPPER= 13823,
	WAXED_OXIDIZED_CUT_COPPER= 22582,
	/**
	 * BlockData: {@link Stairs}
	 */
	WAXED_CUT_COPPER_STAIRS= 23125,
	/**
	 * BlockData: {@link Stairs}
	 */
	WAXED_EXPOSED_CUT_COPPER_STAIRS= 15532,
	/**
	 * BlockData: {@link Stairs}
	 */
	WAXED_WEATHERED_CUT_COPPER_STAIRS= 29701,
	/**
	 * BlockData: {@link Stairs}
	 */
	WAXED_OXIDIZED_CUT_COPPER_STAIRS= 9842,
	/**
	 * BlockData: {@link Slab}
	 */
	WAXED_CUT_COPPER_SLAB= 6271,
	/**
	 * BlockData: {@link Slab}
	 */
	WAXED_EXPOSED_CUT_COPPER_SLAB= 22091,
	/**
	 * BlockData: {@link Slab}
	 */
	WAXED_WEATHERED_CUT_COPPER_SLAB= 20035,
	/**
	 * BlockData: {@link Slab}
	 */
	WAXED_OXIDIZED_CUT_COPPER_SLAB= 11202,
	/**
	 * BlockData: {@link Orientable}
	 */
	OAK_LOG= 26723,
	/**
	 * BlockData: {@link Orientable}
	 */
	SPRUCE_LOG= 9726,
	/**
	 * BlockData: {@link Orientable}
	 */
	BIRCH_LOG= 26727,
	/**
	 * BlockData: {@link Orientable}
	 */
	JUNGLE_LOG= 20721,
	/**
	 * BlockData: {@link Orientable}
	 */
	ACACIA_LOG= 8385,
	/**
	 * BlockData: {@link Orientable}
	 */
	DARK_OAK_LOG= 14831,
	/**
	 * BlockData: {@link Orientable}
	 */
	CRIMSON_STEM= 27920,
	/**
	 * BlockData: {@link Orientable}
	 */
	WARPED_STEM= 28920,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_OAK_LOG= 20523,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_SPRUCE_LOG= 6140,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_BIRCH_LOG= 8838,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_JUNGLE_LOG= 15476,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_ACACIA_LOG= 18167,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_DARK_OAK_LOG= 6492,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_CRIMSON_STEM= 16882,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_WARPED_STEM= 15627,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_OAK_WOOD= 31455,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_SPRUCE_WOOD= 6467,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_BIRCH_WOOD= 22350,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_JUNGLE_WOOD= 30315,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_ACACIA_WOOD= 27193,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_DARK_OAK_WOOD= 16000,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_CRIMSON_HYPHAE= 27488,
	/**
	 * BlockData: {@link Orientable}
	 */
	STRIPPED_WARPED_HYPHAE= 7422,
	/**
	 * BlockData: {@link Orientable}
	 */
	OAK_WOOD= 7378,
	/**
	 * BlockData: {@link Orientable}
	 */
	SPRUCE_WOOD= 32328,
	/**
	 * BlockData: {@link Orientable}
	 */
	BIRCH_WOOD= 20913,
	/**
	 * BlockData: {@link Orientable}
	 */
	JUNGLE_WOOD= 10341,
	/**
	 * BlockData: {@link Orientable}
	 */
	ACACIA_WOOD= 9541,
	/**
	 * BlockData: {@link Orientable}
	 */
	DARK_OAK_WOOD= 16995,
	/**
	 * BlockData: {@link Orientable}
	 */
	CRIMSON_HYPHAE= 6550,
	/**
	 * BlockData: {@link Orientable}
	 */
	WARPED_HYPHAE= 18439,
	/**
	 * BlockData: {@link Leaves}
	 */
	OAK_LEAVES= 4385,
	/**
	 * BlockData: {@link Leaves}
	 */
	SPRUCE_LEAVES= 20039,
	/**
	 * BlockData: {@link Leaves}
	 */
	BIRCH_LEAVES= 12601,
	/**
	 * BlockData: {@link Leaves}
	 */
	JUNGLE_LEAVES= 5133,
	/**
	 * BlockData: {@link Leaves}
	 */
	ACACIA_LEAVES= 16606,
	/**
	 * BlockData: {@link Leaves}
	 */
	DARK_OAK_LEAVES= 22254,
	/**
	 * BlockData: {@link Leaves}
	 */
	AZALEA_LEAVES= 23001,
	/**
	 * BlockData: {@link Leaves}
	 */
	FLOWERING_AZALEA_LEAVES= 20893,
	SPONGE= 15860,
	WET_SPONGE= 9043,
	GLASS= 6195,
	TINTED_GLASS= 19154,
	LAPIS_BLOCK= 14485,
	SANDSTONE= 13141,
	CHISELED_SANDSTONE= 31763,
	CUT_SANDSTONE= 6118,
	COBWEB= 9469,
	GRASS= 6155,
	FERN= 15794,
	AZALEA= 29386,
	FLOWERING_AZALEA= 28270,
	DEAD_BUSH= 22888,
	SEAGRASS= 23942,
	/**
	 * BlockData: {@link SeaPickle}
	 */
	SEA_PICKLE= 19562,
	WHITE_WOOL= 8624,
	ORANGE_WOOL= 23957,
	MAGENTA_WOOL= 11853,
	LIGHT_BLUE_WOOL= 21073,
	YELLOW_WOOL= 29507,
	LIME_WOOL= 10443,
	PINK_WOOL= 7611,
	GRAY_WOOL= 27209,
	LIGHT_GRAY_WOOL= 22936,
	CYAN_WOOL= 12221,
	PURPLE_WOOL= 11922,
	BLUE_WOOL= 15738,
	BROWN_WOOL= 32638,
	GREEN_WOOL= 25085,
	RED_WOOL= 11621,
	BLACK_WOOL= 16693,
	DANDELION= 30558,
	POPPY= 12851,
	BLUE_ORCHID= 13432,
	ALLIUM= 6871,
	AZURE_BLUET= 17608,
	RED_TULIP= 16781,
	ORANGE_TULIP= 26038,
	WHITE_TULIP= 31495,
	PINK_TULIP= 27319,
	OXEYE_DAISY= 11709,
	CORNFLOWER= 15405,
	LILY_OF_THE_VALLEY= 7185,
	WITHER_ROSE= 8619,
	SPORE_BLOSSOM= 20627,
	BROWN_MUSHROOM= 9665,
	RED_MUSHROOM= 19728,
	CRIMSON_FUNGUS= 26268,
	WARPED_FUNGUS= 19799,
	CRIMSON_ROOTS= 14064,
	WARPED_ROOTS= 13932,
	NETHER_SPROUTS= 10431,
	/**
	 * BlockData: {@link Ageable}
	 */
	WEEPING_VINES= 29267,
	/**
	 * BlockData: {@link Ageable}
	 */
	TWISTING_VINES= 27283,
	/**
	 * BlockData: {@link Ageable}
	 */
	SUGAR_CANE= 7726,
	/**
	 * BlockData: {@link Ageable}
	 */
	KELP= 21916,
	MOSS_CARPET= 8221,
	MOSS_BLOCK= 9175,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	HANGING_ROOTS= 15498,
	/**
	 * BlockData: {@link BigDripleaf}
	 */
	BIG_DRIPLEAF= 26173,
	/**
	 * BlockData: {@link SmallDripleaf}
	 */
	SMALL_DRIPLEAF= 17540,
	/**
	 * BlockData: {@link Bamboo}
	 */
	BAMBOO= 18728,
	/**
	 * BlockData: {@link Slab}
	 */
	OAK_SLAB= 12002,
	/**
	 * BlockData: {@link Slab}
	 */
	SPRUCE_SLAB= 28798,
	/**
	 * BlockData: {@link Slab}
	 */
	BIRCH_SLAB= 13807,
	/**
	 * BlockData: {@link Slab}
	 */
	JUNGLE_SLAB= 19117,
	/**
	 * BlockData: {@link Slab}
	 */
	ACACIA_SLAB= 23730,
	/**
	 * BlockData: {@link Slab}
	 */
	DARK_OAK_SLAB= 28852,
	/**
	 * BlockData: {@link Slab}
	 */
	CRIMSON_SLAB= 4691,
	/**
	 * BlockData: {@link Slab}
	 */
	WARPED_SLAB= 27150,
	/**
	 * BlockData: {@link Slab}
	 */
	STONE_SLAB= 19838,
	/**
	 * BlockData: {@link Slab}
	 */
	SMOOTH_STONE_SLAB= 24129,
	/**
	 * BlockData: {@link Slab}
	 */
	SANDSTONE_SLAB= 29830,
	/**
	 * BlockData: {@link Slab}
	 */
	CUT_SANDSTONE_SLAB= 30944,
	/**
	 * BlockData: {@link Slab}
	 */
	PETRIFIED_OAK_SLAB= 18658,
	/**
	 * BlockData: {@link Slab}
	 */
	COBBLESTONE_SLAB= 6340,
	/**
	 * BlockData: {@link Slab}
	 */
	BRICK_SLAB= 26333,
	/**
	 * BlockData: {@link Slab}
	 */
	STONE_BRICK_SLAB= 19676,
	/**
	 * BlockData: {@link Slab}
	 */
	NETHER_BRICK_SLAB= 26586,
	/**
	 * BlockData: {@link Slab}
	 */
	QUARTZ_SLAB= 4423,
	/**
	 * BlockData: {@link Slab}
	 */
	RED_SANDSTONE_SLAB= 17550,
	/**
	 * BlockData: {@link Slab}
	 */
	CUT_RED_SANDSTONE_SLAB= 7220,
	/**
	 * BlockData: {@link Slab}
	 */
	PURPUR_SLAB= 11487,
	/**
	 * BlockData: {@link Slab}
	 */
	PRISMARINE_SLAB= 31323,
	/**
	 * BlockData: {@link Slab}
	 */
	PRISMARINE_BRICK_SLAB= 25624,
	/**
	 * BlockData: {@link Slab}
	 */
	DARK_PRISMARINE_SLAB= 7577,
	SMOOTH_QUARTZ= 14415,
	SMOOTH_RED_SANDSTONE= 25180,
	SMOOTH_SANDSTONE= 30039,
	SMOOTH_STONE= 21910,
	BRICKS= 14165,
	BOOKSHELF= 10069,
	MOSSY_COBBLESTONE= 21900,
	OBSIDIAN= 32723,
	TORCH= 6063,
	/**
	 * BlockData: {@link Directional}
	 */
	END_ROD= 24832,
	/**
	 * BlockData: {@link MultipleFacing}
	 */
	CHORUS_PLANT= 28243,
	/**
	 * BlockData: {@link Ageable}
	 */
	CHORUS_FLOWER= 28542,
	PURPUR_BLOCK= 7538,
	/**
	 * BlockData: {@link Orientable}
	 */
	PURPUR_PILLAR= 26718,
	/**
	 * BlockData: {@link Stairs}
	 */
	PURPUR_STAIRS= 8921,
	SPAWNER= 7018,
	/**
	 * BlockData: {@link Stairs}
	 */
	OAK_STAIRS= 5449,
	/**
	 * BlockData: {@link Chest}
	 */
	CHEST= 22969,
	CRAFTING_TABLE= 20706,
	/**
	 * BlockData: {@link Farmland}
	 */
	FARMLAND= 31166,
	/**
	 * BlockData: {@link Furnace}
	 */
	FURNACE= 8133,
	/**
	 * BlockData: {@link Ladder}
	 */
	LADDER= 23599,
	/**
	 * BlockData: {@link Stairs}
	 */
	COBBLESTONE_STAIRS= 24715,
	/**
	 * BlockData: {@link Snow}
	 */
	SNOW= 14146,
	ICE= 30428,
	SNOW_BLOCK= 19913,
	/**
	 * BlockData: {@link Ageable}
	 */
	CACTUS= 12191,
	CLAY= 27880,
	/**
	 * BlockData: {@link Jukebox}
	 */
	JUKEBOX= 19264,
	/**
	 * BlockData: {@link Fence}
	 */
	OAK_FENCE= 6442,
	/**
	 * BlockData: {@link Fence}
	 */
	SPRUCE_FENCE= 25416,
	/**
	 * BlockData: {@link Fence}
	 */
	BIRCH_FENCE= 17347,
	/**
	 * BlockData: {@link Fence}
	 */
	JUNGLE_FENCE= 14358,
	/**
	 * BlockData: {@link Fence}
	 */
	ACACIA_FENCE= 4569,
	/**
	 * BlockData: {@link Fence}
	 */
	DARK_OAK_FENCE= 21767,
	/**
	 * BlockData: {@link Fence}
	 */
	CRIMSON_FENCE= 21075,
	/**
	 * BlockData: {@link Fence}
	 */
	WARPED_FENCE= 18438,
	PUMPKIN= 19170,
	/**
	 * BlockData: {@link Directional}
	 */
	CARVED_PUMPKIN= 25833,
	/**
	 * BlockData: {@link Directional}
	 */
	JACK_O_LANTERN= 13758,
	NETHERRACK= 23425,
	SOUL_SAND= 16841,
	SOUL_SOIL= 31140,
	/**
	 * BlockData: {@link Orientable}
	 */
	BASALT= 28478,
	/**
	 * BlockData: {@link Orientable}
	 */
	POLISHED_BASALT= 11659,
	SMOOTH_BASALT= 13617,
	/**
	 * BlockData: {@link Lightable}
	 */
	SOUL_TORCH= 14292,
	GLOWSTONE= 32713,
	INFESTED_STONE= 18440,
	INFESTED_COBBLESTONE= 4348,
	INFESTED_STONE_BRICKS= 19749,
	INFESTED_MOSSY_STONE_BRICKS= 9850,
	INFESTED_CRACKED_STONE_BRICKS= 7476,
	INFESTED_CHISELED_STONE_BRICKS= 4728,
	/**
	 * BlockData: {@link Orientable}
	 */
	INFESTED_DEEPSLATE= 9472,
	STONE_BRICKS= 6962,
	MOSSY_STONE_BRICKS= 16415,
	CRACKED_STONE_BRICKS= 27869,
	CHISELED_STONE_BRICKS= 9087,
	DEEPSLATE_BRICKS= 13193,
	CRACKED_DEEPSLATE_BRICKS= 17105,
	DEEPSLATE_TILES= 11250,
	CRACKED_DEEPSLATE_TILES= 26249,
	CHISELED_DEEPSLATE= 23825,
	/**
	 * BlockData: {@link MultipleFacing}
	 */
	BROWN_MUSHROOM_BLOCK= 6291,
	/**
	 * BlockData: {@link MultipleFacing}
	 */
	RED_MUSHROOM_BLOCK= 20766,
	/**
	 * BlockData: {@link MultipleFacing}
	 */
	MUSHROOM_STEM= 16543,
	/**
	 * BlockData: {@link Fence}
	 */
	IRON_BARS= 9378,
	/**
	 * BlockData: {@link Chain}
	 */
	CHAIN= 28265,
	/**
	 * BlockData: {@link Fence}
	 */
	GLASS_PANE= 5709,
	MELON= 25172,
	/**
	 * BlockData: {@link MultipleFacing}
	 */
	VINE= 14564,
	/**
	 * BlockData: {@link GlowLichen}
	 */
	GLOW_LICHEN= 19165,
	/**
	 * BlockData: {@link Stairs}
	 */
	BRICK_STAIRS= 21534,
	/**
	 * BlockData: {@link Stairs}
	 */
	STONE_BRICK_STAIRS= 27032,
	/**
	 * BlockData: {@link Snowable}
	 */
	MYCELIUM= 9913,
	LILY_PAD= 19271,
	NETHER_BRICKS= 27802,
	CRACKED_NETHER_BRICKS= 10888,
	CHISELED_NETHER_BRICKS= 21613,
	/**
	 * BlockData: {@link Fence}
	 */
	NETHER_BRICK_FENCE= 5286,
	/**
	 * BlockData: {@link Stairs}
	 */
	NETHER_BRICK_STAIRS= 12085,
	ENCHANTING_TABLE= 16255,
	/**
	 * BlockData: {@link EndPortalFrame}
	 */
	END_PORTAL_FRAME= 15480,
	END_STONE= 29686,
	END_STONE_BRICKS= 20314,
	DRAGON_EGG= 29946,
	/**
	 * BlockData: {@link Stairs}
	 */
	SANDSTONE_STAIRS= 18474,
	/**
	 * BlockData: {@link EnderChest}
	 */
	ENDER_CHEST= 32349,
	EMERALD_BLOCK= 9914,
	/**
	 * BlockData: {@link Stairs}
	 */
	SPRUCE_STAIRS= 11192,
	/**
	 * BlockData: {@link Stairs}
	 */
	BIRCH_STAIRS= 7657,
	/**
	 * BlockData: {@link Stairs}
	 */
	JUNGLE_STAIRS= 20636,
	/**
	 * BlockData: {@link Stairs}
	 */
	CRIMSON_STAIRS= 32442,
	/**
	 * BlockData: {@link Stairs}
	 */
	WARPED_STAIRS= 17721,
	/**
	 * BlockData: {@link CommandBlock}
	 */
	COMMAND_BLOCK= 4355,
	BEACON= 6608,
	/**
	 * BlockData: {@link Wall}
	 */
	COBBLESTONE_WALL= 12616,
	/**
	 * BlockData: {@link Wall}
	 */
	MOSSY_COBBLESTONE_WALL= 11536,
	/**
	 * BlockData: {@link Wall}
	 */
	BRICK_WALL= 18995,
	/**
	 * BlockData: {@link Wall}
	 */
	PRISMARINE_WALL= 18184,
	/**
	 * BlockData: {@link Wall}
	 */
	RED_SANDSTONE_WALL= 4753,
	/**
	 * BlockData: {@link Wall}
	 */
	MOSSY_STONE_BRICK_WALL= 18259,
	/**
	 * BlockData: {@link Wall}
	 */
	GRANITE_WALL= 23279,
	/**
	 * BlockData: {@link Wall}
	 */
	STONE_BRICK_WALL= 29073,
	/**
	 * BlockData: {@link Wall}
	 */
	NETHER_BRICK_WALL= 10398,
	/**
	 * BlockData: {@link Wall}
	 */
	ANDESITE_WALL= 14938,
	/**
	 * BlockData: {@link Wall}
	 */
	RED_NETHER_BRICK_WALL= 4580,
	/**
	 * BlockData: {@link Wall}
	 */
	SANDSTONE_WALL= 18470,
	/**
	 * BlockData: {@link Wall}
	 */
	END_STONE_BRICK_WALL= 27225,
	/**
	 * BlockData: {@link Wall}
	 */
	DIORITE_WALL= 17412,
	/**
	 * BlockData: {@link Wall}
	 */
	BLACKSTONE_WALL= 17327,
	/**
	 * BlockData: {@link Wall}
	 */
	POLISHED_BLACKSTONE_WALL= 15119,
	/**
	 * BlockData: {@link Wall}
	 */
	POLISHED_BLACKSTONE_BRICK_WALL= 9540,
	/**
	 * BlockData: {@link Wall}
	 */
	COBBLED_DEEPSLATE_WALL= 21893,
	/**
	 * BlockData: {@link Wall}
	 */
	POLISHED_DEEPSLATE_WALL= 6574,
	/**
	 * BlockData: {@link Wall}
	 */
	DEEPSLATE_BRICK_WALL= 13304,
	/**
	 * BlockData: {@link Wall}
	 */
	DEEPSLATE_TILE_WALL= 17077,
	/**
	 * BlockData: {@link Directional}
	 */
	ANVIL= 18718,
	/**
	 * BlockData: {@link Directional}
	 */
	CHIPPED_ANVIL= 10623,
	/**
	 * BlockData: {@link Directional}
	 */
	DAMAGED_ANVIL= 10274,
	CHISELED_QUARTZ_BLOCK= 30964,
	QUARTZ_BLOCK= 11987,
	QUARTZ_BRICKS= 23358,
	/**
	 * BlockData: {@link Orientable}
	 */
	QUARTZ_PILLAR= 16452,
	/**
	 * BlockData: {@link Stairs}
	 */
	QUARTZ_STAIRS= 24079,
	WHITE_TERRACOTTA= 20975,
	ORANGE_TERRACOTTA= 18684,
	MAGENTA_TERRACOTTA= 25900,
	LIGHT_BLUE_TERRACOTTA= 31779,
	YELLOW_TERRACOTTA= 32129,
	LIME_TERRACOTTA= 24013,
	PINK_TERRACOTTA= 23727,
	GRAY_TERRACOTTA= 18004,
	LIGHT_GRAY_TERRACOTTA= 26388,
	CYAN_TERRACOTTA= 25940,
	PURPLE_TERRACOTTA= 10387,
	BLUE_TERRACOTTA= 5236,
	BROWN_TERRACOTTA= 23664,
	GREEN_TERRACOTTA= 4105,
	RED_TERRACOTTA= 5086,
	BLACK_TERRACOTTA= 26691,
	BARRIER= 26453,
	/**
	 * BlockData: {@link Light}
	 */
	LIGHT= 17829,
	/**
	 * BlockData: {@link Orientable}
	 */
	HAY_BLOCK= 17461,
	WHITE_CARPET= 15117,
	ORANGE_CARPET= 24752,
	MAGENTA_CARPET= 6180,
	LIGHT_BLUE_CARPET= 21194,
	YELLOW_CARPET= 18149,
	LIME_CARPET= 15443,
	PINK_CARPET= 27381,
	GRAY_CARPET= 26991,
	LIGHT_GRAY_CARPET= 11317,
	CYAN_CARPET= 9742,
	PURPLE_CARPET= 5574,
	BLUE_CARPET= 13292,
	BROWN_CARPET= 23352,
	GREEN_CARPET= 7780,
	RED_CARPET= 5424,
	BLACK_CARPET= 6056,
	TERRACOTTA= 16544,
	PACKED_ICE= 28993,
	/**
	 * BlockData: {@link Stairs}
	 */
	ACACIA_STAIRS= 17453,
	/**
	 * BlockData: {@link Stairs}
	 */
	DARK_OAK_STAIRS= 22921,
	DIRT_PATH= 10846,
	/**
	 * BlockData: {@link Bisected}
	 */
	SUNFLOWER= 7408,
	/**
	 * BlockData: {@link Bisected}
	 */
	LILAC= 22837,
	/**
	 * BlockData: {@link Bisected}
	 */
	ROSE_BUSH= 6080,
	/**
	 * BlockData: {@link Bisected}
	 */
	PEONY= 21155,
	/**
	 * BlockData: {@link Bisected}
	 */
	TALL_GRASS= 21559,
	/**
	 * BlockData: {@link Bisected}
	 */
	LARGE_FERN= 30177,
	WHITE_STAINED_GLASS= 31190,
	ORANGE_STAINED_GLASS= 25142,
	MAGENTA_STAINED_GLASS= 26814,
	LIGHT_BLUE_STAINED_GLASS= 17162,
	YELLOW_STAINED_GLASS= 12182,
	LIME_STAINED_GLASS= 24266,
	PINK_STAINED_GLASS= 16164,
	GRAY_STAINED_GLASS= 29979,
	LIGHT_GRAY_STAINED_GLASS= 5843,
	CYAN_STAINED_GLASS= 30604,
	PURPLE_STAINED_GLASS= 21845,
	BLUE_STAINED_GLASS= 7107,
	BROWN_STAINED_GLASS= 20945,
	GREEN_STAINED_GLASS= 22503,
	RED_STAINED_GLASS= 9717,
	BLACK_STAINED_GLASS= 13941,
	/**
	 * BlockData: {@link GlassPane}
	 */
	WHITE_STAINED_GLASS_PANE= 10557,
	/**
	 * BlockData: {@link GlassPane}
	 */
	ORANGE_STAINED_GLASS_PANE= 21089,
	/**
	 * BlockData: {@link GlassPane}
	 */
	MAGENTA_STAINED_GLASS_PANE= 14082,
	/**
	 * BlockData: {@link GlassPane}
	 */
	LIGHT_BLUE_STAINED_GLASS_PANE= 18721,
	/**
	 * BlockData: {@link GlassPane}
	 */
	YELLOW_STAINED_GLASS_PANE= 20298,
	/**
	 * BlockData: {@link GlassPane}
	 */
	LIME_STAINED_GLASS_PANE= 10610,
	/**
	 * BlockData: {@link GlassPane}
	 */
	PINK_STAINED_GLASS_PANE= 24637,
	/**
	 * BlockData: {@link GlassPane}
	 */
	GRAY_STAINED_GLASS_PANE= 25272,
	/**
	 * BlockData: {@link GlassPane}
	 */
	LIGHT_GRAY_STAINED_GLASS_PANE= 19008,
	/**
	 * BlockData: {@link GlassPane}
	 */
	CYAN_STAINED_GLASS_PANE= 11784,
	/**
	 * BlockData: {@link GlassPane}
	 */
	PURPLE_STAINED_GLASS_PANE= 10948,
	/**
	 * BlockData: {@link GlassPane}
	 */
	BLUE_STAINED_GLASS_PANE= 28484,
	/**
	 * BlockData: {@link GlassPane}
	 */
	BROWN_STAINED_GLASS_PANE= 17557,
	/**
	 * BlockData: {@link GlassPane}
	 */
	GREEN_STAINED_GLASS_PANE= 4767,
	/**
	 * BlockData: {@link GlassPane}
	 */
	RED_STAINED_GLASS_PANE= 8630,
	/**
	 * BlockData: {@link GlassPane}
	 */
	BLACK_STAINED_GLASS_PANE= 13201,
	PRISMARINE= 7539,
	PRISMARINE_BRICKS= 29118,
	DARK_PRISMARINE= 19940,
	/**
	 * BlockData: {@link Stairs}
	 */
	PRISMARINE_STAIRS= 19217,
	/**
	 * BlockData: {@link Stairs}
	 */
	PRISMARINE_BRICK_STAIRS= 15445,
	/**
	 * BlockData: {@link Stairs}
	 */
	DARK_PRISMARINE_STAIRS= 26511,
	SEA_LANTERN= 20780,
	RED_SANDSTONE= 9092,
	CHISELED_RED_SANDSTONE= 15529,
	CUT_RED_SANDSTONE= 29108,
	/**
	 * BlockData: {@link Stairs}
	 */
	RED_SANDSTONE_STAIRS= 25466,
	/**
	 * BlockData: {@link CommandBlock}
	 */
	REPEATING_COMMAND_BLOCK= 12405,
	/**
	 * BlockData: {@link CommandBlock}
	 */
	CHAIN_COMMAND_BLOCK= 26798,
	MAGMA_BLOCK= 25927,
	NETHER_WART_BLOCK= 15486,
	WARPED_WART_BLOCK= 15463,
	RED_NETHER_BRICKS= 18056,
	/**
	 * BlockData: {@link Orientable}
	 */
	BONE_BLOCK= 17312,
	STRUCTURE_VOID= 30806,
	/**
	 * BlockData: {@link Directional}
	 */
	SHULKER_BOX= 7776,
	/**
	 * BlockData: {@link Directional}
	 */
	WHITE_SHULKER_BOX= 31750,
	/**
	 * BlockData: {@link Directional}
	 */
	ORANGE_SHULKER_BOX= 21673,
	/**
	 * BlockData: {@link Directional}
	 */
	MAGENTA_SHULKER_BOX= 21566,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_BLUE_SHULKER_BOX= 18226,
	/**
	 * BlockData: {@link Directional}
	 */
	YELLOW_SHULKER_BOX= 28700,
	/**
	 * BlockData: {@link Directional}
	 */
	LIME_SHULKER_BOX= 28360,
	/**
	 * BlockData: {@link Directional}
	 */
	PINK_SHULKER_BOX= 24968,
	/**
	 * BlockData: {@link Directional}
	 */
	GRAY_SHULKER_BOX= 12754,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_GRAY_SHULKER_BOX= 21345,
	/**
	 * BlockData: {@link Directional}
	 */
	CYAN_SHULKER_BOX= 28123,
	/**
	 * BlockData: {@link Directional}
	 */
	PURPLE_SHULKER_BOX= 10373,
	/**
	 * BlockData: {@link Directional}
	 */
	BLUE_SHULKER_BOX= 11476,
	/**
	 * BlockData: {@link Directional}
	 */
	BROWN_SHULKER_BOX= 24230,
	/**
	 * BlockData: {@link Directional}
	 */
	GREEN_SHULKER_BOX= 9377,
	/**
	 * BlockData: {@link Directional}
	 */
	RED_SHULKER_BOX= 32448,
	/**
	 * BlockData: {@link Directional}
	 */
	BLACK_SHULKER_BOX= 24076,
	/**
	 * BlockData: {@link Directional}
	 */
	WHITE_GLAZED_TERRACOTTA= 11326,
	/**
	 * BlockData: {@link Directional}
	 */
	ORANGE_GLAZED_TERRACOTTA= 27451,
	/**
	 * BlockData: {@link Directional}
	 */
	MAGENTA_GLAZED_TERRACOTTA= 8067,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_BLUE_GLAZED_TERRACOTTA= 4336,
	/**
	 * BlockData: {@link Directional}
	 */
	YELLOW_GLAZED_TERRACOTTA= 10914,
	/**
	 * BlockData: {@link Directional}
	 */
	LIME_GLAZED_TERRACOTTA= 13861,
	/**
	 * BlockData: {@link Directional}
	 */
	PINK_GLAZED_TERRACOTTA= 10260,
	/**
	 * BlockData: {@link Directional}
	 */
	GRAY_GLAZED_TERRACOTTA= 6256,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_GRAY_GLAZED_TERRACOTTA= 10707,
	/**
	 * BlockData: {@link Directional}
	 */
	CYAN_GLAZED_TERRACOTTA= 9550,
	/**
	 * BlockData: {@link Directional}
	 */
	PURPLE_GLAZED_TERRACOTTA= 4818,
	/**
	 * BlockData: {@link Directional}
	 */
	BLUE_GLAZED_TERRACOTTA= 23823,
	/**
	 * BlockData: {@link Directional}
	 */
	BROWN_GLAZED_TERRACOTTA= 5655,
	/**
	 * BlockData: {@link Directional}
	 */
	GREEN_GLAZED_TERRACOTTA= 6958,
	/**
	 * BlockData: {@link Directional}
	 */
	RED_GLAZED_TERRACOTTA= 24989,
	/**
	 * BlockData: {@link Directional}
	 */
	BLACK_GLAZED_TERRACOTTA= 29678,
	WHITE_CONCRETE= 6281,
	ORANGE_CONCRETE= 19914,
	MAGENTA_CONCRETE= 20591,
	LIGHT_BLUE_CONCRETE= 29481,
	YELLOW_CONCRETE= 15722,
	LIME_CONCRETE= 5863,
	PINK_CONCRETE= 5227,
	GRAY_CONCRETE= 13959,
	LIGHT_GRAY_CONCRETE= 14453,
	CYAN_CONCRETE= 26522,
	PURPLE_CONCRETE= 20623,
	BLUE_CONCRETE= 18756,
	BROWN_CONCRETE= 19006,
	GREEN_CONCRETE= 17949,
	RED_CONCRETE= 8032,
	BLACK_CONCRETE= 13338,
	WHITE_CONCRETE_POWDER= 10363,
	ORANGE_CONCRETE_POWDER= 30159,
	MAGENTA_CONCRETE_POWDER= 8272,
	LIGHT_BLUE_CONCRETE_POWDER= 31206,
	YELLOW_CONCRETE_POWDER= 10655,
	LIME_CONCRETE_POWDER= 28859,
	PINK_CONCRETE_POWDER= 6421,
	GRAY_CONCRETE_POWDER= 13031,
	LIGHT_GRAY_CONCRETE_POWDER= 21589,
	CYAN_CONCRETE_POWDER= 15734,
	PURPLE_CONCRETE_POWDER= 26808,
	BLUE_CONCRETE_POWDER= 17773,
	BROWN_CONCRETE_POWDER= 21485,
	GREEN_CONCRETE_POWDER= 6904,
	RED_CONCRETE_POWDER= 13286,
	BLACK_CONCRETE_POWDER= 16150,
	/**
	 * BlockData: {@link TurtleEgg}
	 */
	TURTLE_EGG= 32101,
	DEAD_TUBE_CORAL_BLOCK= 28350,
	DEAD_BRAIN_CORAL_BLOCK= 12979,
	DEAD_BUBBLE_CORAL_BLOCK= 28220,
	DEAD_FIRE_CORAL_BLOCK= 5307,
	DEAD_HORN_CORAL_BLOCK= 15103,
	TUBE_CORAL_BLOCK= 23723,
	BRAIN_CORAL_BLOCK= 30618,
	BUBBLE_CORAL_BLOCK= 15437,
	FIRE_CORAL_BLOCK= 12119,
	HORN_CORAL_BLOCK= 19958,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	TUBE_CORAL= 23048,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	BRAIN_CORAL= 31316,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	BUBBLE_CORAL= 12464,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	FIRE_CORAL= 29151,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	HORN_CORAL= 19511,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_BRAIN_CORAL= 9116,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_BUBBLE_CORAL= 30583,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_FIRE_CORAL= 8365,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_HORN_CORAL= 5755,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_TUBE_CORAL= 18028,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	TUBE_CORAL_FAN= 19929,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	BRAIN_CORAL_FAN= 13849,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	BUBBLE_CORAL_FAN= 10795,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	FIRE_CORAL_FAN= 11112,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	HORN_CORAL_FAN= 13610,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_TUBE_CORAL_FAN= 17628,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_BRAIN_CORAL_FAN= 26150,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_BUBBLE_CORAL_FAN= 17322,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_FIRE_CORAL_FAN= 27073,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	DEAD_HORN_CORAL_FAN= 11387,
	BLUE_ICE= 22449,
	/**
	 * BlockData: {@link Waterlogged}
	 */
	CONDUIT= 5148,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_GRANITE_STAIRS= 29588,
	/**
	 * BlockData: {@link Stairs}
	 */
	SMOOTH_RED_SANDSTONE_STAIRS= 17561,
	/**
	 * BlockData: {@link Stairs}
	 */
	MOSSY_STONE_BRICK_STAIRS= 27578,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_DIORITE_STAIRS= 4625,
	/**
	 * BlockData: {@link Stairs}
	 */
	MOSSY_COBBLESTONE_STAIRS= 29210,
	/**
	 * BlockData: {@link Stairs}
	 */
	END_STONE_BRICK_STAIRS= 28831,
	/**
	 * BlockData: {@link Stairs}
	 */
	STONE_STAIRS= 23784,
	/**
	 * BlockData: {@link Stairs}
	 */
	SMOOTH_SANDSTONE_STAIRS= 21183,
	/**
	 * BlockData: {@link Stairs}
	 */
	SMOOTH_QUARTZ_STAIRS= 19560,
	/**
	 * BlockData: {@link Stairs}
	 */
	GRANITE_STAIRS= 21840,
	/**
	 * BlockData: {@link Stairs}
	 */
	ANDESITE_STAIRS= 17747,
	/**
	 * BlockData: {@link Stairs}
	 */
	RED_NETHER_BRICK_STAIRS= 26374,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_ANDESITE_STAIRS= 7573,
	/**
	 * BlockData: {@link Stairs}
	 */
	DIORITE_STAIRS= 13134,
	/**
	 * BlockData: {@link Stairs}
	 */
	COBBLED_DEEPSLATE_STAIRS= 20699,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_DEEPSLATE_STAIRS= 19513,
	/**
	 * BlockData: {@link Stairs}
	 */
	DEEPSLATE_BRICK_STAIRS= 29624,
	/**
	 * BlockData: {@link Stairs}
	 */
	DEEPSLATE_TILE_STAIRS= 6361,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_GRANITE_SLAB= 4521,
	/**
	 * BlockData: {@link Slab}
	 */
	SMOOTH_RED_SANDSTONE_SLAB= 16304,
	/**
	 * BlockData: {@link Slab}
	 */
	MOSSY_STONE_BRICK_SLAB= 14002,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_DIORITE_SLAB= 18303,
	/**
	 * BlockData: {@link Slab}
	 */
	MOSSY_COBBLESTONE_SLAB= 12139,
	/**
	 * BlockData: {@link Slab}
	 */
	END_STONE_BRICK_SLAB= 23239,
	/**
	 * BlockData: {@link Slab}
	 */
	SMOOTH_SANDSTONE_SLAB= 9030,
	/**
	 * BlockData: {@link Slab}
	 */
	SMOOTH_QUARTZ_SLAB= 26543,
	/**
	 * BlockData: {@link Slab}
	 */
	GRANITE_SLAB= 10901,
	/**
	 * BlockData: {@link Slab}
	 */
	ANDESITE_SLAB= 32124,
	/**
	 * BlockData: {@link Slab}
	 */
	RED_NETHER_BRICK_SLAB= 12462,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_ANDESITE_SLAB= 24573,
	/**
	 * BlockData: {@link Slab}
	 */
	DIORITE_SLAB= 10715,
	/**
	 * BlockData: {@link Slab}
	 */
	COBBLED_DEEPSLATE_SLAB= 17388,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_DEEPSLATE_SLAB= 32201,
	/**
	 * BlockData: {@link Slab}
	 */
	DEEPSLATE_BRICK_SLAB= 23910,
	/**
	 * BlockData: {@link Slab}
	 */
	DEEPSLATE_TILE_SLAB= 13315,
	/**
	 * BlockData: {@link Scaffolding}
	 */
	SCAFFOLDING= 15757,
	REDSTONE= 11233,
	/**
	 * BlockData: {@link Lightable}
	 */
	REDSTONE_TORCH= 22547,
	REDSTONE_BLOCK= 19496,
	/**
	 * BlockData: {@link Repeater}
	 */
	REPEATER= 28823,
	/**
	 * BlockData: {@link Comparator}
	 */
	COMPARATOR= 18911,
	/**
	 * BlockData: {@link Piston}
	 */
	PISTON= 21130,
	/**
	 * BlockData: {@link Piston}
	 */
	STICKY_PISTON= 18127,
	SLIME_BLOCK= 31892,
	HONEY_BLOCK= 30615,
	/**
	 * BlockData: {@link Observer}
	 */
	OBSERVER= 10726,
	/**
	 * BlockData: {@link Hopper}
	 */
	HOPPER= 31974,
	/**
	 * BlockData: {@link Dispenser}
	 */
	DISPENSER= 20871,
	/**
	 * BlockData: {@link Dispenser}
	 */
	DROPPER= 31273,
	/**
	 * BlockData: {@link Lectern}
	 */
	LECTERN= 23490,
	/**
	 * BlockData: {@link AnaloguePowerable}
	 */
	TARGET= 22637,
	/**
	 * BlockData: {@link Switch}
	 */
	LEVER= 15319,
	/**
	 * BlockData: {@link LightningRod}
	 */
	LIGHTNING_ROD= 30770,
	/**
	 * BlockData: {@link DaylightDetector}
	 */
	DAYLIGHT_DETECTOR= 8864,
	/**
	 * BlockData: {@link SculkSensor}
	 */
	SCULK_SENSOR= 5598,
	/**
	 * BlockData: {@link TripwireHook}
	 */
	TRIPWIRE_HOOK= 8130,
	/**
	 * BlockData: {@link Chest}
	 */
	TRAPPED_CHEST= 18970,
	/**
	 * BlockData: {@link TNT}
	 */
	TNT= 7896,
	/**
	 * BlockData: {@link Lightable}
	 */
	REDSTONE_LAMP= 8217,
	/**
	 * BlockData: {@link NoteBlock}
	 */
	NOTE_BLOCK= 20979,
	/**
	 * BlockData: {@link Switch}
	 */
	STONE_BUTTON= 12279,
	/**
	 * BlockData: {@link Switch}
	 */
	POLISHED_BLACKSTONE_BUTTON= 20760,
	/**
	 * BlockData: {@link Switch}
	 */
	OAK_BUTTON= 13510,
	/**
	 * BlockData: {@link Switch}
	 */
	SPRUCE_BUTTON= 23281,
	/**
	 * BlockData: {@link Switch}
	 */
	BIRCH_BUTTON= 26934,
	/**
	 * BlockData: {@link Switch}
	 */
	JUNGLE_BUTTON= 25317,
	/**
	 * BlockData: {@link Switch}
	 */
	ACACIA_BUTTON= 13993,
	/**
	 * BlockData: {@link Switch}
	 */
	DARK_OAK_BUTTON= 6214,
	/**
	 * BlockData: {@link Switch}
	 */
	CRIMSON_BUTTON= 26799,
	/**
	 * BlockData: {@link Switch}
	 */
	WARPED_BUTTON= 25264,
	/**
	 * BlockData: {@link Powerable}
	 */
	STONE_PRESSURE_PLATE= 22591,
	/**
	 * BlockData: {@link Powerable}
	 */
	POLISHED_BLACKSTONE_PRESSURE_PLATE= 32340,
	/**
	 * BlockData: {@link AnaloguePowerable}
	 */
	LIGHT_WEIGHTED_PRESSURE_PLATE= 14875,
	/**
	 * BlockData: {@link AnaloguePowerable}
	 */
	HEAVY_WEIGHTED_PRESSURE_PLATE= 16970,
	/**
	 * BlockData: {@link Powerable}
	 */
	OAK_PRESSURE_PLATE= 20108,
	/**
	 * BlockData: {@link Powerable}
	 */
	SPRUCE_PRESSURE_PLATE= 15932,
	/**
	 * BlockData: {@link Powerable}
	 */
	BIRCH_PRESSURE_PLATE= 9664,
	/**
	 * BlockData: {@link Powerable}
	 */
	JUNGLE_PRESSURE_PLATE= 11376,
	/**
	 * BlockData: {@link Powerable}
	 */
	ACACIA_PRESSURE_PLATE= 17586,
	/**
	 * BlockData: {@link Powerable}
	 */
	DARK_OAK_PRESSURE_PLATE= 31375,
	/**
	 * BlockData: {@link Powerable}
	 */
	CRIMSON_PRESSURE_PLATE= 18316,
	/**
	 * BlockData: {@link Powerable}
	 */
	WARPED_PRESSURE_PLATE= 29516,
	/**
	 * BlockData: {@link Door}
	 */
	IRON_DOOR= 4788,
	/**
	 * BlockData: {@link Door}
	 */
	OAK_DOOR= 20341,
	/**
	 * BlockData: {@link Door}
	 */
	SPRUCE_DOOR= 10642,
	/**
	 * BlockData: {@link Door}
	 */
	BIRCH_DOOR= 14759,
	/**
	 * BlockData: {@link Door}
	 */
	JUNGLE_DOOR= 28163,
	/**
	 * BlockData: {@link Door}
	 */
	ACACIA_DOOR= 23797,
	/**
	 * BlockData: {@link Door}
	 */
	DARK_OAK_DOOR= 10669,
	/**
	 * BlockData: {@link Door}
	 */
	CRIMSON_DOOR= 19544,
	/**
	 * BlockData: {@link Door}
	 */
	WARPED_DOOR= 15062,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	IRON_TRAPDOOR= 17095,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	OAK_TRAPDOOR= 16927,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	SPRUCE_TRAPDOOR= 10289,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	BIRCH_TRAPDOOR= 32585,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	JUNGLE_TRAPDOOR= 8626,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	ACACIA_TRAPDOOR= 18343,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	DARK_OAK_TRAPDOOR= 10355,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	CRIMSON_TRAPDOOR= 25056,
	/**
	 * BlockData: {@link TrapDoor}
	 */
	WARPED_TRAPDOOR= 7708,
	/**
	 * BlockData: {@link Gate}
	 */
	OAK_FENCE_GATE= 16689,
	/**
	 * BlockData: {@link Gate}
	 */
	SPRUCE_FENCE_GATE= 26423,
	/**
	 * BlockData: {@link Gate}
	 */
	BIRCH_FENCE_GATE= 6322,
	/**
	 * BlockData: {@link Gate}
	 */
	JUNGLE_FENCE_GATE= 21360,
	/**
	 * BlockData: {@link Gate}
	 */
	ACACIA_FENCE_GATE= 14145,
	/**
	 * BlockData: {@link Gate}
	 */
	DARK_OAK_FENCE_GATE= 10679,
	/**
	 * BlockData: {@link Gate}
	 */
	CRIMSON_FENCE_GATE= 15602,
	/**
	 * BlockData: {@link Gate}
	 */
	WARPED_FENCE_GATE= 11115,
	/**
	 * BlockData: {@link RedstoneRail}
	 */
	POWERED_RAIL= 11064,
	/**
	 * BlockData: {@link RedstoneRail}
	 */
	DETECTOR_RAIL= 13475,
	/**
	 * BlockData: {@link Rail}
	 */
	RAIL= 13285,
	/**
	 * BlockData: {@link RedstoneRail}
	 */
	ACTIVATOR_RAIL= 5834,
	SADDLE= 30206,
	MINECART= 14352,
	CHEST_MINECART= 4497,
	FURNACE_MINECART= 14196,
	TNT_MINECART= 4277,
	HOPPER_MINECART= 19024,
	CARROT_ON_A_STICK= 27809,
	WARPED_FUNGUS_ON_A_STICK= 11706,
	ELYTRA= 23829,
	OAK_BOAT= 17570,
	SPRUCE_BOAT= 31427,
	BIRCH_BOAT= 28104,
	JUNGLE_BOAT= 4495,
	ACACIA_BOAT= 27326,
	DARK_OAK_BOAT= 28618,
	/**
	 * BlockData: {@link StructureBlock}
	 */
	STRUCTURE_BLOCK= 26831,
	/**
	 * BlockData: {@link Jigsaw}
	 */
	JIGSAW= 17398,
	TURTLE_HELMET= 30120,
	SCUTE= 11914,
	FLINT_AND_STEEL= 28620,
	APPLE= 7720,
	BOW= 8745,
	ARROW= 31091,
	COAL= 29067,
	CHARCOAL= 5390,
	DIAMOND= 20865,
	EMERALD= 5654,
	LAPIS_LAZULI= 11075,
	QUARTZ= 23608,
	AMETHYST_SHARD= 7613,
	RAW_IRON= 5329,
	IRON_INGOT= 24895,
	RAW_COPPER= 6162,
	COPPER_INGOT= 12611,
	RAW_GOLD= 19564,
	GOLD_INGOT= 28927,
	NETHERITE_INGOT= 32457,
	NETHERITE_SCRAP= 29331,
	WOODEN_SWORD= 7175,
	WOODEN_SHOVEL= 28432,
	WOODEN_PICKAXE= 12792,
	WOODEN_AXE= 6292,
	WOODEN_HOE= 16043,
	STONE_SWORD= 25084,
	STONE_SHOVEL= 9520,
	STONE_PICKAXE= 14611,
	STONE_AXE= 6338,
	STONE_HOE= 22855,
	GOLDEN_SWORD= 10505,
	GOLDEN_SHOVEL= 15597,
	GOLDEN_PICKAXE= 25898,
	GOLDEN_AXE= 4878,
	GOLDEN_HOE= 19337,
	IRON_SWORD= 10904,
	IRON_SHOVEL= 30045,
	IRON_PICKAXE= 8842,
	IRON_AXE= 15894,
	IRON_HOE= 11339,
	DIAMOND_SWORD= 27707,
	DIAMOND_SHOVEL= 25415,
	DIAMOND_PICKAXE= 24291,
	DIAMOND_AXE= 27277,
	DIAMOND_HOE= 24050,
	NETHERITE_SWORD= 23871,
	NETHERITE_SHOVEL= 29728,
	NETHERITE_PICKAXE= 9930,
	NETHERITE_AXE= 29533,
	NETHERITE_HOE= 27385,
	STICK= 9773,
	BOWL= 32661,
	MUSHROOM_STEW= 16336,
	STRING= 12806,
	FEATHER= 30548,
	GUNPOWDER= 29974,
	WHEAT_SEEDS= 28742,
	/**
	 * BlockData: {@link Ageable}
	 */
	WHEAT= 27709,
	BREAD= 32049,
	LEATHER_HELMET= 11624,
	LEATHER_CHESTPLATE= 29275,
	LEATHER_LEGGINGS= 28210,
	LEATHER_BOOTS= 15282,
	CHAINMAIL_HELMET= 26114,
	CHAINMAIL_CHESTPLATE= 23602,
	CHAINMAIL_LEGGINGS= 19087,
	CHAINMAIL_BOOTS= 17953,
	IRON_HELMET= 12025,
	IRON_CHESTPLATE= 28112,
	IRON_LEGGINGS= 18951,
	IRON_BOOTS= 8531,
	DIAMOND_HELMET= 10755,
	DIAMOND_CHESTPLATE= 32099,
	DIAMOND_LEGGINGS= 26500,
	DIAMOND_BOOTS= 16522,
	GOLDEN_HELMET= 7945,
	GOLDEN_CHESTPLATE= 4507,
	GOLDEN_LEGGINGS= 21002,
	GOLDEN_BOOTS= 7859,
	NETHERITE_HELMET= 15907,
	NETHERITE_CHESTPLATE= 6106,
	NETHERITE_LEGGINGS= 25605,
	NETHERITE_BOOTS= 8923,
	FLINT= 23596,
	PORKCHOP= 30896,
	COOKED_PORKCHOP= 27231,
	PAINTING= 23945,
	GOLDEN_APPLE= 27732,
	ENCHANTED_GOLDEN_APPLE= 8280,
	/**
	 * BlockData: {@link Sign}
	 */
	OAK_SIGN= 8192,
	/**
	 * BlockData: {@link Sign}
	 */
	SPRUCE_SIGN= 21502,
	/**
	 * BlockData: {@link Sign}
	 */
	BIRCH_SIGN= 11351,
	/**
	 * BlockData: {@link Sign}
	 */
	JUNGLE_SIGN= 24717,
	/**
	 * BlockData: {@link Sign}
	 */
	ACACIA_SIGN= 29808,
	/**
	 * BlockData: {@link Sign}
	 */
	DARK_OAK_SIGN= 15127,
	/**
	 * BlockData: {@link Sign}
	 */
	CRIMSON_SIGN= 12162,
	/**
	 * BlockData: {@link Sign}
	 */
	WARPED_SIGN= 10407,
	BUCKET= 15215,
	WATER_BUCKET= 8802,
	LAVA_BUCKET= 9228,
	POWDER_SNOW_BUCKET= 31101,
	SNOWBALL= 19487,
	LEATHER= 16414,
	MILK_BUCKET= 9680,
	PUFFERFISH_BUCKET= 8861,
	SALMON_BUCKET= 9606,
	COD_BUCKET= 28601,
	TROPICAL_FISH_BUCKET= 29995,
	AXOLOTL_BUCKET= 20669,
	BRICK= 6820,
	CLAY_BALL= 24603,
	DRIED_KELP_BLOCK= 12966,
	PAPER= 9923,
	BOOK= 23097,
	SLIME_BALL= 5242,
	EGG= 21603,
	COMPASS= 24139,
	BUNDLE= 16835,
	FISHING_ROD= 4167,
	CLOCK= 14980,
	SPYGLASS= 27490,
	GLOWSTONE_DUST= 6665,
	COD= 24691,
	SALMON= 18516,
	TROPICAL_FISH= 24879,
	PUFFERFISH= 8115,
	COOKED_COD= 9681,
	COOKED_SALMON= 5615,
	INK_SAC= 7184,
	GLOW_INK_SAC= 9686,
	COCOA_BEANS= 30186,
	WHITE_DYE= 10758,
	ORANGE_DYE= 13866,
	MAGENTA_DYE= 11788,
	LIGHT_BLUE_DYE= 28738,
	YELLOW_DYE= 5952,
	LIME_DYE= 6147,
	PINK_DYE= 31151,
	GRAY_DYE= 9184,
	LIGHT_GRAY_DYE= 27643,
	CYAN_DYE= 8043,
	PURPLE_DYE= 6347,
	BLUE_DYE= 11588,
	BROWN_DYE= 7648,
	GREEN_DYE= 23215,
	RED_DYE= 5728,
	BLACK_DYE= 6202,
	BONE_MEAL= 32458,
	BONE= 5686,
	SUGAR= 30638,
	/**
	 * BlockData: {@link Cake}
	 */
	CAKE= 27048,
	/**
	 * BlockData: {@link Bed}
	 */
	WHITE_BED= 8185,
	/**
	 * BlockData: {@link Bed}
	 */
	ORANGE_BED= 11194,
	/**
	 * BlockData: {@link Bed}
	 */
	MAGENTA_BED= 20061,
	/**
	 * BlockData: {@link Bed}
	 */
	LIGHT_BLUE_BED= 20957,
	/**
	 * BlockData: {@link Bed}
	 */
	YELLOW_BED= 30410,
	/**
	 * BlockData: {@link Bed}
	 */
	LIME_BED= 27860,
	/**
	 * BlockData: {@link Bed}
	 */
	PINK_BED= 13795,
	/**
	 * BlockData: {@link Bed}
	 */
	GRAY_BED= 15745,
	/**
	 * BlockData: {@link Bed}
	 */
	LIGHT_GRAY_BED= 5090,
	/**
	 * BlockData: {@link Bed}
	 */
	CYAN_BED= 16746,
	/**
	 * BlockData: {@link Bed}
	 */
	PURPLE_BED= 29755,
	/**
	 * BlockData: {@link Bed}
	 */
	BLUE_BED= 12714,
	/**
	 * BlockData: {@link Bed}
	 */
	BROWN_BED= 26672,
	/**
	 * BlockData: {@link Bed}
	 */
	GREEN_BED= 13797,
	/**
	 * BlockData: {@link Bed}
	 */
	RED_BED= 30910,
	/**
	 * BlockData: {@link Bed}
	 */
	BLACK_BED= 20490,
	COOKIE= 27431,
	FILLED_MAP= 23504,
	SHEARS= 27971,
	MELON_SLICE= 5347,
	DRIED_KELP= 21042,
	PUMPKIN_SEEDS= 28985,
	MELON_SEEDS= 18340,
	BEEF= 4803,
	COOKED_BEEF= 21595,
	CHICKEN= 17281,
	COOKED_CHICKEN= 16984,
	ROTTEN_FLESH= 21591,
	ENDER_PEARL= 5259,
	BLAZE_ROD= 8289,
	GHAST_TEAR= 18222,
	GOLD_NUGGET= 28814,
	/**
	 * BlockData: {@link Ageable}
	 */
	NETHER_WART= 29227,
	POTION= 24020,
	GLASS_BOTTLE= 6116,
	SPIDER_EYE= 9318,
	FERMENTED_SPIDER_EYE= 19386,
	BLAZE_POWDER= 18941,
	MAGMA_CREAM= 25097,
	/**
	 * BlockData: {@link BrewingStand}
	 */
	BREWING_STAND= 14539,
	CAULDRON= 26531,
	ENDER_EYE= 24860,
	GLISTERING_MELON_SLICE= 20158,
	AXOLOTL_SPAWN_EGG= 30381,
	BAT_SPAWN_EGG= 14607,
	BEE_SPAWN_EGG= 22924,
	BLAZE_SPAWN_EGG= 4759,
	CAT_SPAWN_EGG= 29583,
	CAVE_SPIDER_SPAWN_EGG= 23341,
	CHICKEN_SPAWN_EGG= 5462,
	COD_SPAWN_EGG= 27248,
	COW_SPAWN_EGG= 14761,
	CREEPER_SPAWN_EGG= 9653,
	DOLPHIN_SPAWN_EGG= 20787,
	DONKEY_SPAWN_EGG= 14513,
	DROWNED_SPAWN_EGG= 19368,
	ELDER_GUARDIAN_SPAWN_EGG= 11418,
	ENDERMAN_SPAWN_EGG= 29488,
	ENDERMITE_SPAWN_EGG= 16617,
	EVOKER_SPAWN_EGG= 21271,
	FOX_SPAWN_EGG= 22376,
	GHAST_SPAWN_EGG= 9970,
	GLOW_SQUID_SPAWN_EGG= 31578,
	GOAT_SPAWN_EGG= 30639,
	GUARDIAN_SPAWN_EGG= 20113,
	HOGLIN_SPAWN_EGG= 14088,
	HORSE_SPAWN_EGG= 25981,
	HUSK_SPAWN_EGG= 20178,
	LLAMA_SPAWN_EGG= 23640,
	MAGMA_CUBE_SPAWN_EGG= 26638,
	MOOSHROOM_SPAWN_EGG= 22125,
	MULE_SPAWN_EGG= 11229,
	OCELOT_SPAWN_EGG= 30080,
	PANDA_SPAWN_EGG= 23759,
	PARROT_SPAWN_EGG= 23614,
	PHANTOM_SPAWN_EGG= 24648,
	PIG_SPAWN_EGG= 22584,
	PIGLIN_SPAWN_EGG= 16193,
	PIGLIN_BRUTE_SPAWN_EGG= 30230,
	PILLAGER_SPAWN_EGG= 28659,
	POLAR_BEAR_SPAWN_EGG= 17015,
	PUFFERFISH_SPAWN_EGG= 24570,
	RABBIT_SPAWN_EGG= 26496,
	RAVAGER_SPAWN_EGG= 8726,
	SALMON_SPAWN_EGG= 18739,
	SHEEP_SPAWN_EGG= 24488,
	SHULKER_SPAWN_EGG= 31848,
	SILVERFISH_SPAWN_EGG= 14537,
	SKELETON_SPAWN_EGG= 15261,
	SKELETON_HORSE_SPAWN_EGG= 21356,
	SLIME_SPAWN_EGG= 17196,
	SPIDER_SPAWN_EGG= 14984,
	SQUID_SPAWN_EGG= 10682,
	STRAY_SPAWN_EGG= 30153,
	STRIDER_SPAWN_EGG= 6203,
	TRADER_LLAMA_SPAWN_EGG= 8439,
	TROPICAL_FISH_SPAWN_EGG= 19713,
	TURTLE_SPAWN_EGG= 17324,
	VEX_SPAWN_EGG= 27751,
	VILLAGER_SPAWN_EGG= 30348,
	VINDICATOR_SPAWN_EGG= 25324,
	WANDERING_TRADER_SPAWN_EGG= 17904,
	WITCH_SPAWN_EGG= 11837,
	WITHER_SKELETON_SPAWN_EGG= 10073,
	WOLF_SPAWN_EGG= 21692,
	ZOGLIN_SPAWN_EGG= 7442,
	ZOMBIE_SPAWN_EGG= 5814,
	ZOMBIE_HORSE_SPAWN_EGG= 4275,
	ZOMBIE_VILLAGER_SPAWN_EGG= 10311,
	ZOMBIFIED_PIGLIN_SPAWN_EGG= 6626,
	EXPERIENCE_BOTTLE= 12858,
	FIRE_CHARGE= 4842,
	WRITABLE_BOOK= 13393,
	WRITTEN_BOOK= 24164,
	ITEM_FRAME= 27318,
	GLOW_ITEM_FRAME= 26473,
	FLOWER_POT= 30567,
	CARROT= 22824,
	POTATO= 21088,
	BAKED_POTATO= 14624,
	POISONOUS_POTATO= 32640,
	MAP= 21655,
	GOLDEN_CARROT= 5300,
	/**
	 * BlockData: {@link Rotatable}
	 */
	SKELETON_SKULL= 13270,
	/**
	 * BlockData: {@link Rotatable}
	 */
	WITHER_SKELETON_SKULL= 31487,
	/**
	 * BlockData: {@link Rotatable}
	 */
	PLAYER_HEAD= 21174,
	/**
	 * BlockData: {@link Rotatable}
	 */
	ZOMBIE_HEAD= 9304,
	/**
	 * BlockData: {@link Rotatable}
	 */
	CREEPER_HEAD= 29146,
	/**
	 * BlockData: {@link Rotatable}
	 */
	DRAGON_HEAD= 20084,
	NETHER_STAR= 12469,
	PUMPKIN_PIE= 28725,
	FIREWORK_ROCKET= 23841,
	FIREWORK_STAR= 12190,
	ENCHANTED_BOOK= 11741,
	NETHER_BRICK= 19996,
	PRISMARINE_SHARD= 10993,
	PRISMARINE_CRYSTALS= 31546,
	RABBIT= 23068,
	COOKED_RABBIT= 4454,
	RABBIT_STEW= 10611,
	RABBIT_FOOT= 13864,
	RABBIT_HIDE= 12467,
	ARMOR_STAND= 12852,
	IRON_HORSE_ARMOR= 30108,
	GOLDEN_HORSE_ARMOR= 7996,
	DIAMOND_HORSE_ARMOR= 10321,
	LEATHER_HORSE_ARMOR= 30667,
	LEAD= 29539,
	NAME_TAG= 30731,
	COMMAND_BLOCK_MINECART= 7992,
	MUTTON= 4792,
	COOKED_MUTTON= 31447,
	/**
	 * BlockData: {@link Rotatable}
	 */
	WHITE_BANNER= 17562,
	/**
	 * BlockData: {@link Rotatable}
	 */
	ORANGE_BANNER= 4839,
	/**
	 * BlockData: {@link Rotatable}
	 */
	MAGENTA_BANNER= 15591,
	/**
	 * BlockData: {@link Rotatable}
	 */
	LIGHT_BLUE_BANNER= 18060,
	/**
	 * BlockData: {@link Rotatable}
	 */
	YELLOW_BANNER= 30382,
	/**
	 * BlockData: {@link Rotatable}
	 */
	LIME_BANNER= 18887,
	/**
	 * BlockData: {@link Rotatable}
	 */
	PINK_BANNER= 19439,
	/**
	 * BlockData: {@link Rotatable}
	 */
	GRAY_BANNER= 12053,
	/**
	 * BlockData: {@link Rotatable}
	 */
	LIGHT_GRAY_BANNER= 11417,
	/**
	 * BlockData: {@link Rotatable}
	 */
	CYAN_BANNER= 9839,
	/**
	 * BlockData: {@link Rotatable}
	 */
	PURPLE_BANNER= 29027,
	/**
	 * BlockData: {@link Rotatable}
	 */
	BLUE_BANNER= 18481,
	/**
	 * BlockData: {@link Rotatable}
	 */
	BROWN_BANNER= 11481,
	/**
	 * BlockData: {@link Rotatable}
	 */
	GREEN_BANNER= 10698,
	/**
	 * BlockData: {@link Rotatable}
	 */
	RED_BANNER= 26961,
	/**
	 * BlockData: {@link Rotatable}
	 */
	BLACK_BANNER= 9365,
	END_CRYSTAL= 19090,
	CHORUS_FRUIT= 7652,
	POPPED_CHORUS_FRUIT= 27844,
	BEETROOT= 23305,
	BEETROOT_SEEDS= 21282,
	BEETROOT_SOUP= 16036,
	DRAGON_BREATH= 20154,
	SPLASH_POTION= 30248,
	SPECTRAL_ARROW= 4568,
	TIPPED_ARROW= 25164,
	LINGERING_POTION= 25857,
	SHIELD= 29943,
	TOTEM_OF_UNDYING= 10139,
	SHULKER_SHELL= 27848,
	IRON_NUGGET= 13715,
	KNOWLEDGE_BOOK= 12646,
	DEBUG_STICK= 24562,
	MUSIC_DISC_13= 16359,
	MUSIC_DISC_CAT= 16246,
	MUSIC_DISC_BLOCKS= 26667,
	MUSIC_DISC_CHIRP= 19436,
	MUSIC_DISC_FAR= 31742,
	MUSIC_DISC_MALL= 11517,
	MUSIC_DISC_MELLOHI= 26117,
	MUSIC_DISC_STAL= 14989,
	MUSIC_DISC_STRAD= 16785,
	MUSIC_DISC_WARD= 24026,
	MUSIC_DISC_11= 27426,
	MUSIC_DISC_WAIT= 26499,
	MUSIC_DISC_PIGSTEP= 21323,
	TRIDENT= 7534,
	PHANTOM_MEMBRANE= 18398,
	NAUTILUS_SHELL= 19989,
	HEART_OF_THE_SEA= 11807,
	CROSSBOW= 4340,
	SUSPICIOUS_STEW= 8173,
	/**
	 * BlockData: {@link Directional}
	 */
	LOOM= 14276,
	FLOWER_BANNER_PATTERN= 5762,
	CREEPER_BANNER_PATTERN= 15774,
	SKULL_BANNER_PATTERN= 7680,
	MOJANG_BANNER_PATTERN= 11903,
	GLOBE_BANNER_PATTERN= 27753,
	PIGLIN_BANNER_PATTERN= 22028,
	/**
	 * BlockData: {@link Levelled}
	 */
	COMPOSTER= 31247,
	/**
	 * BlockData: {@link Directional}
	 */
	BARREL= 22396,
	/**
	 * BlockData: {@link Furnace}
	 */
	SMOKER= 24781,
	/**
	 * BlockData: {@link Furnace}
	 */
	BLAST_FURNACE= 31157,
	CARTOGRAPHY_TABLE= 28529,
	FLETCHING_TABLE= 30838,
	/**
	 * BlockData: {@link Grindstone}
	 */
	GRINDSTONE= 26260,
	SMITHING_TABLE= 9082,
	/**
	 * BlockData: {@link Directional}
	 */
	STONECUTTER= 25170,
	/**
	 * BlockData: {@link Bell}
	 */
	BELL= 20000,
	/**
	 * BlockData: {@link Lantern}
	 */
	LANTERN= 5992,
	/**
	 * BlockData: {@link Lantern}
	 */
	SOUL_LANTERN= 27778,
	SWEET_BERRIES= 19747,
	GLOW_BERRIES= 11584,
	/**
	 * BlockData: {@link Campfire}
	 */
	CAMPFIRE= 8488,
	/**
	 * BlockData: {@link Campfire}
	 */
	SOUL_CAMPFIRE= 4238,
	SHROOMLIGHT= 20424,
	HONEYCOMB= 9482,
	/**
	 * BlockData: {@link Beehive}
	 */
	BEE_NEST= 8825,
	/**
	 * BlockData: {@link Beehive}
	 */
	BEEHIVE= 11830,
	HONEY_BOTTLE= 22927,
	HONEYCOMB_BLOCK= 28780,
	LODESTONE= 23127,
	CRYING_OBSIDIAN= 31545,
	BLACKSTONE= 7354,
	/**
	 * BlockData: {@link Slab}
	 */
	BLACKSTONE_SLAB= 11948,
	/**
	 * BlockData: {@link Stairs}
	 */
	BLACKSTONE_STAIRS= 14646,
	GILDED_BLACKSTONE= 8498,
	POLISHED_BLACKSTONE= 18144,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_BLACKSTONE_SLAB= 23430,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_BLACKSTONE_STAIRS= 8653,
	CHISELED_POLISHED_BLACKSTONE= 21942,
	POLISHED_BLACKSTONE_BRICKS= 19844,
	/**
	 * BlockData: {@link Slab}
	 */
	POLISHED_BLACKSTONE_BRICK_SLAB= 12219,
	/**
	 * BlockData: {@link Stairs}
	 */
	POLISHED_BLACKSTONE_BRICK_STAIRS= 17983,
	CRACKED_POLISHED_BLACKSTONE_BRICKS= 16846,
	/**
	 * BlockData: {@link RespawnAnchor}
	 */
	RESPAWN_ANCHOR= 4099,
	/**
	 * BlockData: {@link Candle}
	 */
	CANDLE= 16122,
	/**
	 * BlockData: {@link Candle}
	 */
	WHITE_CANDLE= 26410,
	/**
	 * BlockData: {@link Candle}
	 */
	ORANGE_CANDLE= 22668,
	/**
	 * BlockData: {@link Candle}
	 */
	MAGENTA_CANDLE= 25467,
	/**
	 * BlockData: {@link Candle}
	 */
	LIGHT_BLUE_CANDLE= 28681,
	/**
	 * BlockData: {@link Candle}
	 */
	YELLOW_CANDLE= 14351,
	/**
	 * BlockData: {@link Candle}
	 */
	LIME_CANDLE= 21778,
	/**
	 * BlockData: {@link Candle}
	 */
	PINK_CANDLE= 28259,
	/**
	 * BlockData: {@link Candle}
	 */
	GRAY_CANDLE= 10721,
	/**
	 * BlockData: {@link Candle}
	 */
	LIGHT_GRAY_CANDLE= 10031,
	/**
	 * BlockData: {@link Candle}
	 */
	CYAN_CANDLE= 24765,
	/**
	 * BlockData: {@link Candle}
	 */
	PURPLE_CANDLE= 19606,
	/**
	 * BlockData: {@link Candle}
	 */
	BLUE_CANDLE= 29047,
	/**
	 * BlockData: {@link Candle}
	 */
	BROWN_CANDLE= 26145,
	/**
	 * BlockData: {@link Candle}
	 */
	GREEN_CANDLE= 29756,
	/**
	 * BlockData: {@link Candle}
	 */
	RED_CANDLE= 4214,
	/**
	 * BlockData: {@link Candle}
	 */
	BLACK_CANDLE= 12617,
	/**
	 * BlockData: {@link AmethystCluster}
	 */
	SMALL_AMETHYST_BUD= 14958,
	/**
	 * BlockData: {@link AmethystCluster}
	 */
	MEDIUM_AMETHYST_BUD= 8429,
	/**
	 * BlockData: {@link AmethystCluster}
	 */
	LARGE_AMETHYST_BUD= 7279,
	/**
	 * BlockData: {@link AmethystCluster}
	 */
	AMETHYST_CLUSTER= 13142,
	/**
	 * BlockData: {@link PointedDripstone}
	 */
	POINTED_DRIPSTONE= 18755,
	/**
	 * BlockData: {@link Levelled}
	 */
	WATER= 24998,
	/**
	 * BlockData: {@link Levelled}
	 */
	LAVA= 8415,
	/**
	 * BlockData: {@link Bisected}
	 */
	TALL_SEAGRASS= 27189,
	/**
	 * BlockData: {@link PistonHead}
	 */
	PISTON_HEAD= 30226,
	/**
	 * BlockData: {@link TechnicalPiston}
	 */
	MOVING_PISTON= 13831,
	/**
	 * BlockData: {@link Directional}
	 */
	WALL_TORCH= 25890,
	/**
	 * BlockData: {@link Fire}
	 */
	FIRE= 16396,
	/**
	 * BlockData: {@link Fire}
	 */
	SOUL_FIRE= 30163,
	/**
	 * BlockData: {@link RedstoneWire}
	 */
	REDSTONE_WIRE= 25984,
	/**
	 * BlockData: {@link WallSign}
	 */
	OAK_WALL_SIGN= 12984,
	/**
	 * BlockData: {@link WallSign}
	 */
	SPRUCE_WALL_SIGN= 7352,
	/**
	 * BlockData: {@link WallSign}
	 */
	BIRCH_WALL_SIGN= 9887,
	/**
	 * BlockData: {@link WallSign}
	 */
	ACACIA_WALL_SIGN= 20316,
	/**
	 * BlockData: {@link WallSign}
	 */
	JUNGLE_WALL_SIGN= 29629,
	/**
	 * BlockData: {@link WallSign}
	 */
	DARK_OAK_WALL_SIGN= 9508,
	/**
	 * BlockData: {@link RedstoneWallTorch}
	 */
	REDSTONE_WALL_TORCH= 7595,
	/**
	 * BlockData: {@link Directional}
	 */
	SOUL_WALL_TORCH= 27500,
	/**
	 * BlockData: {@link Orientable}
	 */
	NETHER_PORTAL= 19469,
	/**
	 * BlockData: {@link Directional}
	 */
	ATTACHED_PUMPKIN_STEM= 12724,
	/**
	 * BlockData: {@link Directional}
	 */
	ATTACHED_MELON_STEM= 30882,
	/**
	 * BlockData: {@link Ageable}
	 */
	PUMPKIN_STEM= 19021,
	/**
	 * BlockData: {@link Ageable}
	 */
	MELON_STEM= 8247,
	/**
	 * BlockData: {@link Levelled}
	 */
	WATER_CAULDRON= 32008,
	LAVA_CAULDRON= 4514,
	/**
	 * BlockData: {@link Levelled}
	 */
	POWDER_SNOW_CAULDRON= 31571,
	END_PORTAL= 16782,
	/**
	 * BlockData: {@link Cocoa}
	 */
	COCOA= 29709,
	/**
	 * BlockData: {@link Tripwire}
	 */
	TRIPWIRE= 8810,
	POTTED_OAK_SAPLING= 11905,
	POTTED_SPRUCE_SAPLING= 29498,
	POTTED_BIRCH_SAPLING= 32484,
	POTTED_JUNGLE_SAPLING= 7525,
	POTTED_ACACIA_SAPLING= 14096,
	POTTED_DARK_OAK_SAPLING= 6486,
	POTTED_FERN= 23315,
	POTTED_DANDELION= 9727,
	POTTED_POPPY= 7457,
	POTTED_BLUE_ORCHID= 6599,
	POTTED_ALLIUM= 13184,
	POTTED_AZURE_BLUET= 8754,
	POTTED_RED_TULIP= 28594,
	POTTED_ORANGE_TULIP= 28807,
	POTTED_WHITE_TULIP= 24330,
	POTTED_PINK_TULIP= 10089,
	POTTED_OXEYE_DAISY= 19707,
	POTTED_CORNFLOWER= 28917,
	POTTED_LILY_OF_THE_VALLEY= 9364,
	POTTED_WITHER_ROSE= 26876,
	POTTED_RED_MUSHROOM= 22881,
	POTTED_BROWN_MUSHROOM= 14481,
	POTTED_DEAD_BUSH= 13020,
	POTTED_CACTUS= 8777,
	/**
	 * BlockData: {@link Ageable}
	 */
	CARROTS= 17258,
	/**
	 * BlockData: {@link Ageable}
	 */
	POTATOES= 10879,
	/**
	 * BlockData: {@link Directional}
	 */
	SKELETON_WALL_SKULL= 31650,
	/**
	 * BlockData: {@link Directional}
	 */
	WITHER_SKELETON_WALL_SKULL= 9326,
	/**
	 * BlockData: {@link Directional}
	 */
	ZOMBIE_WALL_HEAD= 16296,
	/**
	 * BlockData: {@link Directional}
	 */
	PLAYER_WALL_HEAD= 13164,
	/**
	 * BlockData: {@link Directional}
	 */
	CREEPER_WALL_HEAD= 30123,
	/**
	 * BlockData: {@link Directional}
	 */
	DRAGON_WALL_HEAD= 19818,
	/**
	 * BlockData: {@link Directional}
	 */
	WHITE_WALL_BANNER= 15967,
	/**
	 * BlockData: {@link Directional}
	 */
	ORANGE_WALL_BANNER= 9936,
	/**
	 * BlockData: {@link Directional}
	 */
	MAGENTA_WALL_BANNER= 23291,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_BLUE_WALL_BANNER= 12011,
	/**
	 * BlockData: {@link Directional}
	 */
	YELLOW_WALL_BANNER= 32004,
	/**
	 * BlockData: {@link Directional}
	 */
	LIME_WALL_BANNER= 21422,
	/**
	 * BlockData: {@link Directional}
	 */
	PINK_WALL_BANNER= 9421,
	/**
	 * BlockData: {@link Directional}
	 */
	GRAY_WALL_BANNER= 24275,
	/**
	 * BlockData: {@link Directional}
	 */
	LIGHT_GRAY_WALL_BANNER= 31088,
	/**
	 * BlockData: {@link Directional}
	 */
	CYAN_WALL_BANNER= 10889,
	/**
	 * BlockData: {@link Directional}
	 */
	PURPLE_WALL_BANNER= 14298,
	/**
	 * BlockData: {@link Directional}
	 */
	BLUE_WALL_BANNER= 17757,
	/**
	 * BlockData: {@link Directional}
	 */
	BROWN_WALL_BANNER= 14731,
	/**
	 * BlockData: {@link Directional}
	 */
	GREEN_WALL_BANNER= 15046,
	/**
	 * BlockData: {@link Directional}
	 */
	RED_WALL_BANNER= 4378,
	/**
	 * BlockData: {@link Directional}
	 */
	BLACK_WALL_BANNER= 4919,
	/**
	 * BlockData: {@link Ageable}
	 */
	BEETROOTS= 22075,
	END_GATEWAY= 26605,
	/**
	 * BlockData: {@link Ageable}
	 */
	FROSTED_ICE= 21814,
	KELP_PLANT= 29697,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	DEAD_TUBE_CORAL_WALL_FAN= 5128,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	DEAD_BRAIN_CORAL_WALL_FAN= 23718,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	DEAD_BUBBLE_CORAL_WALL_FAN= 18453,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	DEAD_FIRE_CORAL_WALL_FAN= 23375,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	DEAD_HORN_CORAL_WALL_FAN= 27550,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	TUBE_CORAL_WALL_FAN= 25282,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	BRAIN_CORAL_WALL_FAN= 22685,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	BUBBLE_CORAL_WALL_FAN= 20382,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	FIRE_CORAL_WALL_FAN= 20100,
	/**
	 * BlockData: {@link CoralWallFan}
	 */
	HORN_CORAL_WALL_FAN= 28883,
	BAMBOO_SAPLING= 8478,
	POTTED_BAMBOO= 22542,
	VOID_AIR= 13668,
	CAVE_AIR= 17422,
	/**
	 * BlockData: {@link BubbleColumn}
	 */
	BUBBLE_COLUMN= 31612,
	/**
	 * BlockData: {@link Ageable}
	 */
	SWEET_BERRY_BUSH= 11958,
	WEEPING_VINES_PLANT= 19437,
	TWISTING_VINES_PLANT= 25338,
	/**
	 * BlockData: {@link WallSign}
	 */
	CRIMSON_WALL_SIGN= 19242,
	/**
	 * BlockData: {@link WallSign}
	 */
	WARPED_WALL_SIGN= 13534,
	POTTED_CRIMSON_FUNGUS= 5548,
	POTTED_WARPED_FUNGUS= 30800,
	POTTED_CRIMSON_ROOTS= 13852,
	POTTED_WARPED_ROOTS= 6403,
	/**
	 * BlockData: {@link Lightable}
	 */
	CANDLE_CAKE= 25423,
	/**
	 * BlockData: {@link Lightable}
	 */
	WHITE_CANDLE_CAKE= 12674,
	/**
	 * BlockData: {@link Lightable}
	 */
	ORANGE_CANDLE_CAKE= 24982,
	/**
	 * BlockData: {@link Lightable}
	 */
	MAGENTA_CANDLE_CAKE= 11022,
	/**
	 * BlockData: {@link Lightable}
	 */
	LIGHT_BLUE_CANDLE_CAKE= 7787,
	/**
	 * BlockData: {@link Lightable}
	 */
	YELLOW_CANDLE_CAKE= 17157,
	/**
	 * BlockData: {@link Lightable}
	 */
	LIME_CANDLE_CAKE= 14309,
	/**
	 * BlockData: {@link Lightable}
	 */
	PINK_CANDLE_CAKE= 20405,
	/**
	 * BlockData: {@link Lightable}
	 */
	GRAY_CANDLE_CAKE= 6777,
	/**
	 * BlockData: {@link Lightable}
	 */
	LIGHT_GRAY_CANDLE_CAKE= 11318,
	/**
	 * BlockData: {@link Lightable}
	 */
	CYAN_CANDLE_CAKE= 21202,
	/**
	 * BlockData: {@link Lightable}
	 */
	PURPLE_CANDLE_CAKE= 22663,
	/**
	 * BlockData: {@link Lightable}
	 */
	BLUE_CANDLE_CAKE= 26425,
	/**
	 * BlockData: {@link Lightable}
	 */
	BROWN_CANDLE_CAKE= 26024,
	/**
	 * BlockData: {@link Lightable}
	 */
	GREEN_CANDLE_CAKE= 16334,
	/**
	 * BlockData: {@link Lightable}
	 */
	RED_CANDLE_CAKE= 24151,
	/**
	 * BlockData: {@link Lightable}
	 */
	BLACK_CANDLE_CAKE= 15191,
	POWDER_SNOW= 24077,
	/**
	 * BlockData: {@link CaveVines}
	 */
	CAVE_VINES= 7339,
	/**
	 * BlockData: {@link CaveVinesPlant}
	 */
	CAVE_VINES_PLANT= 30645,
	/**
	 * BlockData: {@link Dripleaf}
	 */
	BIG_DRIPLEAF_STEM= 13167,
	POTTED_AZALEA_BUSH= 20430,
	POTTED_FLOWERING_AZALEA_BUSH= 10609,
	// ----- Legacy Separator -----
	[Obsolete]
	LEGACY_AIR= 0,
	[Obsolete]
	LEGACY_STONE= 1,
	[Obsolete]
	LEGACY_GRASS= 2,
	[Obsolete]
	LEGACY_DIRT= 3,
	[Obsolete]
	LEGACY_COBBLESTONE= 4,
	[Obsolete]
	LEGACY_WOOD= 5,
	[Obsolete]
	LEGACY_SAPLING= 6,
	[Obsolete]
	LEGACY_BEDROCK= 7,
	[Obsolete]
	LEGACY_WATER= 8,
	[Obsolete]
	LEGACY_STATIONARY_WATER= 9,
	[Obsolete]
	LEGACY_LAVA= 10,
	[Obsolete]
	LEGACY_STATIONARY_LAVA= 11,
	[Obsolete]
	LEGACY_SAND= 12,
	[Obsolete]
	LEGACY_GRAVEL= 13,
	[Obsolete]
	LEGACY_GOLD_ORE= 14,
	[Obsolete]
	LEGACY_IRON_ORE= 15,
	[Obsolete]
	LEGACY_COAL_ORE= 16,
	[Obsolete]
	LEGACY_LOG= 17,
	[Obsolete]
	LEGACY_LEAVES= 18,
	[Obsolete]
	LEGACY_SPONGE= 19,
	[Obsolete]
	LEGACY_GLASS= 20,
	[Obsolete]
	LEGACY_LAPIS_ORE= 21,
	[Obsolete]
	LEGACY_LAPIS_BLOCK= 22,
	[Obsolete]
	LEGACY_DISPENSER= 23,
	[Obsolete]
	LEGACY_SANDSTONE= 24,
	[Obsolete]
	LEGACY_NOTE_BLOCK= 25,
	[Obsolete]
	LEGACY_BED_BLOCK= 26,
	[Obsolete]
	LEGACY_POWERED_RAIL= 27,
	[Obsolete]
	LEGACY_DETECTOR_RAIL= 28,
	[Obsolete]
	LEGACY_PISTON_STICKY_BASE= 29,
	[Obsolete]
	LEGACY_WEB= 30,
	[Obsolete]
	LEGACY_LONG_GRASS= 31,
	[Obsolete]
	LEGACY_DEAD_BUSH= 32,
	[Obsolete]
	LEGACY_PISTON_BASE= 33,
	[Obsolete]
	LEGACY_PISTON_EXTENSION= 34,
	[Obsolete]
	LEGACY_WOOL= 35,
	[Obsolete]
	LEGACY_PISTON_MOVING_PIECE= 36,
	[Obsolete]
	LEGACY_YELLOW_FLOWER= 37,
	[Obsolete]
	LEGACY_RED_ROSE= 38,
	[Obsolete]
	LEGACY_BROWN_MUSHROOM= 39,
	[Obsolete]
	LEGACY_RED_MUSHROOM= 40,
	[Obsolete]
	LEGACY_GOLD_BLOCK= 41,
	[Obsolete]
	LEGACY_IRON_BLOCK= 42,
	[Obsolete]
	LEGACY_DOUBLE_STEP= 43,
	[Obsolete]
	LEGACY_STEP= 44,
	[Obsolete]
	LEGACY_BRICK= 45,
	[Obsolete]
	LEGACY_TNT= 46,
	[Obsolete]
	LEGACY_BOOKSHELF= 47,
	[Obsolete]
	LEGACY_MOSSY_COBBLESTONE= 48,
	[Obsolete]
	LEGACY_OBSIDIAN= 49,
	[Obsolete]
	LEGACY_TORCH= 50,
	[Obsolete]
	LEGACY_FIRE= 51,
	[Obsolete]
	LEGACY_MOB_SPAWNER= 52,
	[Obsolete]
	LEGACY_WOOD_STAIRS= 53,
	[Obsolete]
	LEGACY_CHEST= 54,
	[Obsolete]
	LEGACY_REDSTONE_WIRE= 55,
	[Obsolete]
	LEGACY_DIAMOND_ORE= 56,
	[Obsolete]
	LEGACY_DIAMOND_BLOCK= 57,
	[Obsolete]
	LEGACY_WORKBENCH= 58,
	[Obsolete]
	LEGACY_CROPS= 59,
	[Obsolete]
	LEGACY_SOIL= 60,
	[Obsolete]
	LEGACY_FURNACE= 61,
	[Obsolete]
	LEGACY_BURNING_FURNACE= 62,
	[Obsolete]
	LEGACY_SIGN_POST= 63,
	[Obsolete]
	LEGACY_WOODEN_DOOR= 64,
	[Obsolete]
	LEGACY_LADDER= 65,
	[Obsolete]
	LEGACY_RAILS= 66,
	[Obsolete]
	LEGACY_COBBLESTONE_STAIRS= 67,
	[Obsolete]
	LEGACY_WALL_SIGN= 68,
	[Obsolete]
	LEGACY_LEVER= 69,
	[Obsolete]
	LEGACY_STONE_PLATE= 70,
	[Obsolete]
	LEGACY_IRON_DOOR_BLOCK= 71,
	[Obsolete]
	LEGACY_WOOD_PLATE= 72,
	[Obsolete]
	LEGACY_REDSTONE_ORE= 73,
	[Obsolete]
	LEGACY_GLOWING_REDSTONE_ORE= 74,
	[Obsolete]
	LEGACY_REDSTONE_TORCH_OFF= 75,
	[Obsolete]
	LEGACY_REDSTONE_TORCH_ON= 76,
	[Obsolete]
	LEGACY_STONE_BUTTON= 77,
	[Obsolete]
	LEGACY_SNOW= 78,
	[Obsolete]
	LEGACY_ICE= 79,
	[Obsolete]
	LEGACY_SNOW_BLOCK= 80,
	[Obsolete]
	LEGACY_CACTUS= 81,
	[Obsolete]
	LEGACY_CLAY= 82,
	[Obsolete]
	LEGACY_SUGAR_CANE_BLOCK= 83,
	[Obsolete]
	LEGACY_JUKEBOX= 84,
	[Obsolete]
	LEGACY_FENCE= 85,
	[Obsolete]
	LEGACY_PUMPKIN= 86,
	[Obsolete]
	LEGACY_NETHERRACK= 87,
	[Obsolete]
	LEGACY_SOUL_SAND= 88,
	[Obsolete]
	LEGACY_GLOWSTONE= 89,
	[Obsolete]
	LEGACY_PORTAL= 90,
	[Obsolete]
	LEGACY_JACK_O_LANTERN= 91,
	[Obsolete]
	LEGACY_CAKE_BLOCK= 92,
	[Obsolete]
	LEGACY_DIODE_BLOCK_OFF= 93,
	[Obsolete]
	LEGACY_DIODE_BLOCK_ON= 94,
	[Obsolete]
	LEGACY_STAINED_GLASS= 95,
	[Obsolete]
	LEGACY_TRAP_DOOR= 96,
	[Obsolete]
	LEGACY_MONSTER_EGGS= 97,
	[Obsolete]
	LEGACY_SMOOTH_BRICK= 98,
	[Obsolete]
	LEGACY_HUGE_MUSHROOM_1= 99,
	[Obsolete]
	LEGACY_HUGE_MUSHROOM_2= 100,
	[Obsolete]
	LEGACY_IRON_FENCE= 101,
	[Obsolete]
	LEGACY_THIN_GLASS= 102,
	[Obsolete]
	LEGACY_MELON_BLOCK= 103,
	[Obsolete]
	LEGACY_PUMPKIN_STEM= 104,
	[Obsolete]
	LEGACY_MELON_STEM= 105,
	[Obsolete]
	LEGACY_VINE= 106,
	[Obsolete]
	LEGACY_FENCE_GATE= 107,
	[Obsolete]
	LEGACY_BRICK_STAIRS= 108,
	[Obsolete]
	LEGACY_SMOOTH_STAIRS= 109,
	[Obsolete]
	LEGACY_MYCEL= 110,
	[Obsolete]
	LEGACY_WATER_LILY= 111,
	[Obsolete]
	LEGACY_NETHER_BRICK= 112,
	[Obsolete]
	LEGACY_NETHER_FENCE= 113,
	[Obsolete]
	LEGACY_NETHER_BRICK_STAIRS= 114,
	[Obsolete]
	LEGACY_NETHER_WARTS= 115,
	[Obsolete]
	LEGACY_ENCHANTMENT_TABLE= 116,
	[Obsolete]
	LEGACY_BREWING_STAND= 117,
	[Obsolete]
	LEGACY_CAULDRON= 118,
	[Obsolete]
	LEGACY_ENDER_PORTAL= 119,
	[Obsolete]
	LEGACY_ENDER_PORTAL_FRAME= 120,
	[Obsolete]
	LEGACY_ENDER_STONE= 121,
	[Obsolete]
	LEGACY_DRAGON_EGG= 122,
	[Obsolete]
	LEGACY_REDSTONE_LAMP_OFF= 123,
	[Obsolete]
	LEGACY_REDSTONE_LAMP_ON= 124,
	[Obsolete]
	LEGACY_WOOD_DOUBLE_STEP= 125,
	[Obsolete]
	LEGACY_WOOD_STEP= 126,
	[Obsolete]
	LEGACY_COCOA= 127,
	[Obsolete]
	LEGACY_SANDSTONE_STAIRS= 128,
	[Obsolete]
	LEGACY_EMERALD_ORE= 129,
	[Obsolete]
	LEGACY_ENDER_CHEST= 130,
	[Obsolete]
	LEGACY_TRIPWIRE_HOOK= 131,
	[Obsolete]
	LEGACY_TRIPWIRE= 132,
	[Obsolete]
	LEGACY_EMERALD_BLOCK= 133,
	[Obsolete]
	LEGACY_SPRUCE_WOOD_STAIRS= 134,
	[Obsolete]
	LEGACY_BIRCH_WOOD_STAIRS= 135,
	[Obsolete]
	LEGACY_JUNGLE_WOOD_STAIRS= 136,
	[Obsolete]
	LEGACY_COMMAND= 137,
	[Obsolete]
	LEGACY_BEACON= 138,
	[Obsolete]
	LEGACY_COBBLE_WALL= 139,
	[Obsolete]
	LEGACY_FLOWER_POT= 140,
	[Obsolete]
	LEGACY_CARROT= 141,
	[Obsolete]
	LEGACY_POTATO= 142,
	[Obsolete]
	LEGACY_WOOD_BUTTON= 143,
	[Obsolete]
	LEGACY_SKULL= 144,
	[Obsolete]
	LEGACY_ANVIL= 145,
	[Obsolete]
	LEGACY_TRAPPED_CHEST= 146,
	[Obsolete]
	LEGACY_GOLD_PLATE= 147,
	[Obsolete]
	LEGACY_IRON_PLATE= 148,
	[Obsolete]
	LEGACY_REDSTONE_COMPARATOR_OFF= 149,
	[Obsolete]
	LEGACY_REDSTONE_COMPARATOR_ON= 150,
	[Obsolete]
	LEGACY_DAYLIGHT_DETECTOR= 151,
	[Obsolete]
	LEGACY_REDSTONE_BLOCK= 152,
	[Obsolete]
	LEGACY_QUARTZ_ORE= 153,
	[Obsolete]
	LEGACY_HOPPER= 154,
	[Obsolete]
	LEGACY_QUARTZ_BLOCK= 155,
	[Obsolete]
	LEGACY_QUARTZ_STAIRS= 156,
	[Obsolete]
	LEGACY_ACTIVATOR_RAIL= 157,
	[Obsolete]
	LEGACY_DROPPER= 158,
	[Obsolete]
	LEGACY_STAINED_CLAY= 159,
	[Obsolete]
	LEGACY_STAINED_GLASS_PANE= 160,
	[Obsolete]
	LEGACY_LEAVES_2= 161,
	[Obsolete]
	LEGACY_LOG_2= 162,
	[Obsolete]
	LEGACY_ACACIA_STAIRS= 163,
	[Obsolete]
	LEGACY_DARK_OAK_STAIRS= 164,
	[Obsolete]
	LEGACY_SLIME_BLOCK= 165,
	[Obsolete]
	LEGACY_BARRIER= 166,
	[Obsolete]
	LEGACY_IRON_TRAPDOOR= 167,
	[Obsolete]
	LEGACY_PRISMARINE= 168,
	[Obsolete]
	LEGACY_SEA_LANTERN= 169,
	[Obsolete]
	LEGACY_HAY_BLOCK= 170,
	[Obsolete]
	LEGACY_CARPET= 171,
	[Obsolete]
	LEGACY_HARD_CLAY= 172,
	[Obsolete]
	LEGACY_COAL_BLOCK= 173,
	[Obsolete]
	LEGACY_PACKED_ICE= 174,
	[Obsolete]
	LEGACY_DOUBLE_PLANT= 175,
	[Obsolete]
	LEGACY_STANDING_BANNER= 176,
	[Obsolete]
	LEGACY_WALL_BANNER= 177,
	[Obsolete]
	LEGACY_DAYLIGHT_DETECTOR_INVERTED= 178,
	[Obsolete]
	LEGACY_RED_SANDSTONE= 179,
	[Obsolete]
	LEGACY_RED_SANDSTONE_STAIRS= 180,
	[Obsolete]
	LEGACY_DOUBLE_STONE_SLAB2= 181,
	[Obsolete]
	LEGACY_STONE_SLAB2= 182,
	[Obsolete]
	LEGACY_SPRUCE_FENCE_GATE= 183,
	[Obsolete]
	LEGACY_BIRCH_FENCE_GATE= 184,
	[Obsolete]
	LEGACY_JUNGLE_FENCE_GATE= 185,
	[Obsolete]
	LEGACY_DARK_OAK_FENCE_GATE= 186,
	[Obsolete]
	LEGACY_ACACIA_FENCE_GATE= 187,
	[Obsolete]
	LEGACY_SPRUCE_FENCE= 188,
	[Obsolete]
	LEGACY_BIRCH_FENCE= 189,
	[Obsolete]
	LEGACY_JUNGLE_FENCE= 190,
	[Obsolete]
	LEGACY_DARK_OAK_FENCE= 191,
	[Obsolete]
	LEGACY_ACACIA_FENCE= 192,
	[Obsolete]
	LEGACY_SPRUCE_DOOR= 193,
	[Obsolete]
	LEGACY_BIRCH_DOOR= 194,
	[Obsolete]
	LEGACY_JUNGLE_DOOR= 195,
	[Obsolete]
	LEGACY_ACACIA_DOOR= 196,
	[Obsolete]
	LEGACY_DARK_OAK_DOOR= 197,
	[Obsolete]
	LEGACY_END_ROD= 198,
	[Obsolete]
	LEGACY_CHORUS_PLANT= 199,
	[Obsolete]
	LEGACY_CHORUS_FLOWER= 200,
	[Obsolete]
	LEGACY_PURPUR_BLOCK= 201,
	[Obsolete]
	LEGACY_PURPUR_PILLAR= 202,
	[Obsolete]
	LEGACY_PURPUR_STAIRS= 203,
	[Obsolete]
	LEGACY_PURPUR_DOUBLE_SLAB= 204,
	[Obsolete]
	LEGACY_PURPUR_SLAB= 205,
	[Obsolete]
	LEGACY_END_BRICKS= 206,
	[Obsolete]
	LEGACY_BEETROOT_BLOCK= 207,
	[Obsolete]
	LEGACY_GRASS_PATH= 208,
	[Obsolete]
	LEGACY_END_GATEWAY= 209,
	[Obsolete]
	LEGACY_COMMAND_REPEATING= 210,
	[Obsolete]
	LEGACY_COMMAND_CHAIN= 211,
	[Obsolete]
	LEGACY_FROSTED_ICE= 212,
	[Obsolete]
	LEGACY_MAGMA= 213,
	[Obsolete]
	LEGACY_NETHER_WART_BLOCK= 214,
	[Obsolete]
	LEGACY_RED_NETHER_BRICK= 215,
	[Obsolete]
	LEGACY_BONE_BLOCK= 216,
	[Obsolete]
	LEGACY_STRUCTURE_VOID= 217,
	[Obsolete]
	LEGACY_OBSERVER= 218,
	[Obsolete]
	LEGACY_WHITE_SHULKER_BOX= 219,
	[Obsolete]
	LEGACY_ORANGE_SHULKER_BOX= 220,
	[Obsolete]
	LEGACY_MAGENTA_SHULKER_BOX= 221,
	[Obsolete]
	LEGACY_LIGHT_BLUE_SHULKER_BOX= 222,
	[Obsolete]
	LEGACY_YELLOW_SHULKER_BOX= 223,
	[Obsolete]
	LEGACY_LIME_SHULKER_BOX= 224,
	[Obsolete]
	LEGACY_PINK_SHULKER_BOX= 225,
	[Obsolete]
	LEGACY_GRAY_SHULKER_BOX= 226,
	[Obsolete]
	LEGACY_SILVER_SHULKER_BOX= 227,
	[Obsolete]
	LEGACY_CYAN_SHULKER_BOX= 228,
	[Obsolete]
	LEGACY_PURPLE_SHULKER_BOX= 229,
	[Obsolete]
	LEGACY_BLUE_SHULKER_BOX= 230,
	[Obsolete]
	LEGACY_BROWN_SHULKER_BOX= 231,
	[Obsolete]
	LEGACY_GREEN_SHULKER_BOX= 232,
	[Obsolete]
	LEGACY_RED_SHULKER_BOX= 233,
	[Obsolete]
	LEGACY_BLACK_SHULKER_BOX= 234,
	[Obsolete]
	LEGACY_WHITE_GLAZED_TERRACOTTA= 235,
	[Obsolete]
	LEGACY_ORANGE_GLAZED_TERRACOTTA= 236,
	[Obsolete]
	LEGACY_MAGENTA_GLAZED_TERRACOTTA= 237,
	[Obsolete]
	LEGACY_LIGHT_BLUE_GLAZED_TERRACOTTA= 238,
	[Obsolete]
	LEGACY_YELLOW_GLAZED_TERRACOTTA= 239,
	[Obsolete]
	LEGACY_LIME_GLAZED_TERRACOTTA= 240,
	[Obsolete]
	LEGACY_PINK_GLAZED_TERRACOTTA= 241,
	[Obsolete]
	LEGACY_GRAY_GLAZED_TERRACOTTA= 242,
	[Obsolete]
	LEGACY_SILVER_GLAZED_TERRACOTTA= 243,
	[Obsolete]
	LEGACY_CYAN_GLAZED_TERRACOTTA= 244,
	[Obsolete]
	LEGACY_PURPLE_GLAZED_TERRACOTTA= 245,
	[Obsolete]
	LEGACY_BLUE_GLAZED_TERRACOTTA= 246,
	[Obsolete]
	LEGACY_BROWN_GLAZED_TERRACOTTA= 247,
	[Obsolete]
	LEGACY_GREEN_GLAZED_TERRACOTTA= 248,
	[Obsolete]
	LEGACY_RED_GLAZED_TERRACOTTA= 249,
	[Obsolete]
	LEGACY_BLACK_GLAZED_TERRACOTTA= 250,
	[Obsolete]
	LEGACY_CONCRETE= 251,
	[Obsolete]
	LEGACY_CONCRETE_POWDER= 252,
	[Obsolete]
	LEGACY_STRUCTURE_BLOCK= 255,
	// ----- Item Separator -----
	[Obsolete]
	LEGACY_IRON_SPADE= 256,
	[Obsolete]
	LEGACY_IRON_PICKAXE= 257,
	[Obsolete]
	LEGACY_IRON_AXE= 258,
	[Obsolete]
	LEGACY_FLINT_AND_STEEL= 259,
	[Obsolete]
	LEGACY_APPLE= 260,
	[Obsolete]
	LEGACY_BOW= 261,
	[Obsolete]
	LEGACY_ARROW= 262,
	[Obsolete]
	LEGACY_COAL= 263,
	[Obsolete]
	LEGACY_DIAMOND= 264,
	[Obsolete]
	LEGACY_IRON_INGOT= 265,
	[Obsolete]
	LEGACY_GOLD_INGOT= 266,
	[Obsolete]
	LEGACY_IRON_SWORD= 267,
	[Obsolete]
	LEGACY_WOOD_SWORD= 268,
	[Obsolete]
	LEGACY_WOOD_SPADE= 269,
	[Obsolete]
	LEGACY_WOOD_PICKAXE= 270,
	[Obsolete]
	LEGACY_WOOD_AXE= 271,
	[Obsolete]
	LEGACY_STONE_SWORD= 272,
	[Obsolete]
	LEGACY_STONE_SPADE= 273,
	[Obsolete]
	LEGACY_STONE_PICKAXE= 274,
	[Obsolete]
	LEGACY_STONE_AXE= 275,
	[Obsolete]
	LEGACY_DIAMOND_SWORD= 276,
	[Obsolete]
	LEGACY_DIAMOND_SPADE= 277,
	[Obsolete]
	LEGACY_DIAMOND_PICKAXE= 278,
	[Obsolete]
	LEGACY_DIAMOND_AXE= 279,
	[Obsolete]
	LEGACY_STICK= 280,
	[Obsolete]
	LEGACY_BOWL= 281,
	[Obsolete]
	LEGACY_MUSHROOM_SOUP= 282,
	[Obsolete]
	LEGACY_GOLD_SWORD= 283,
	[Obsolete]
	LEGACY_GOLD_SPADE= 284,
	[Obsolete]
	LEGACY_GOLD_PICKAXE= 285,
	[Obsolete]
	LEGACY_GOLD_AXE= 286,
	[Obsolete]
	LEGACY_STRING= 287,
	[Obsolete]
	LEGACY_FEATHER= 288,
	[Obsolete]
	LEGACY_SULPHUR= 289,
	[Obsolete]
	LEGACY_WOOD_HOE= 290,
	[Obsolete]
	LEGACY_STONE_HOE= 291,
	[Obsolete]
	LEGACY_IRON_HOE= 292,
	[Obsolete]
	LEGACY_DIAMOND_HOE= 293,
	[Obsolete]
	LEGACY_GOLD_HOE= 294,
	[Obsolete]
	LEGACY_SEEDS= 295,
	[Obsolete]
	LEGACY_WHEAT= 296,
	[Obsolete]
	LEGACY_BREAD= 297,
	[Obsolete]
	LEGACY_LEATHER_HELMET= 298,
	[Obsolete]
	LEGACY_LEATHER_CHESTPLATE= 299,
	[Obsolete]
	LEGACY_LEATHER_LEGGINGS= 300,
	[Obsolete]
	LEGACY_LEATHER_BOOTS= 301,
	[Obsolete]
	LEGACY_CHAINMAIL_HELMET= 302,
	[Obsolete]
	LEGACY_CHAINMAIL_CHESTPLATE= 303,
	[Obsolete]
	LEGACY_CHAINMAIL_LEGGINGS= 304,
	[Obsolete]
	LEGACY_CHAINMAIL_BOOTS= 305,
	[Obsolete]
	LEGACY_IRON_HELMET= 306,
	[Obsolete]
	LEGACY_IRON_CHESTPLATE= 307,
	[Obsolete]
	LEGACY_IRON_LEGGINGS= 308,
	[Obsolete]
	LEGACY_IRON_BOOTS= 309,
	[Obsolete]
	LEGACY_DIAMOND_HELMET= 310,
	[Obsolete]
	LEGACY_DIAMOND_CHESTPLATE= 311,
	[Obsolete]
	LEGACY_DIAMOND_LEGGINGS= 312,
	[Obsolete]
	LEGACY_DIAMOND_BOOTS= 313,
	[Obsolete]
	LEGACY_GOLD_HELMET= 314,
	[Obsolete]
	LEGACY_GOLD_CHESTPLATE= 315,
	[Obsolete]
	LEGACY_GOLD_LEGGINGS= 316,
	[Obsolete]
	LEGACY_GOLD_BOOTS= 317,
	[Obsolete]
	LEGACY_FLINT= 318,
	[Obsolete]
	LEGACY_PORK= 319,
	[Obsolete]
	LEGACY_GRILLED_PORK= 320,
	[Obsolete]
	LEGACY_PAINTING= 321,
	[Obsolete]
	LEGACY_GOLDEN_APPLE= 322,
	[Obsolete]
	LEGACY_SIGN= 323,
	[Obsolete]
	LEGACY_WOOD_DOOR= 324,
	[Obsolete]
	LEGACY_BUCKET= 325,
	[Obsolete]
	LEGACY_WATER_BUCKET= 326,
	[Obsolete]
	LEGACY_LAVA_BUCKET= 327,
	[Obsolete]
	LEGACY_MINECART= 328,
	[Obsolete]
	LEGACY_SADDLE= 329,
	[Obsolete]
	LEGACY_IRON_DOOR= 330,
	[Obsolete]
	LEGACY_REDSTONE= 331,
	[Obsolete]
	LEGACY_SNOW_BALL= 332,
	[Obsolete]
	LEGACY_BOAT= 333,
	[Obsolete]
	LEGACY_LEATHER= 334,
	[Obsolete]
	LEGACY_MILK_BUCKET= 335,
	[Obsolete]
	LEGACY_CLAY_BRICK= 336,
	[Obsolete]
	LEGACY_CLAY_BALL= 337,
	[Obsolete]
	LEGACY_SUGAR_CANE= 338,
	[Obsolete]
	LEGACY_PAPER= 339,
	[Obsolete]
	LEGACY_BOOK= 340,
	[Obsolete]
	LEGACY_SLIME_BALL= 341,
	[Obsolete]
	LEGACY_STORAGE_MINECART= 342,
	[Obsolete]
	LEGACY_POWERED_MINECART= 343,
	[Obsolete]
	LEGACY_EGG= 344,
	[Obsolete]
	LEGACY_COMPASS= 345,
	[Obsolete]
	LEGACY_FISHING_ROD= 346,
	[Obsolete]
	LEGACY_WATCH= 347,
	[Obsolete]
	LEGACY_GLOWSTONE_DUST= 348,
	[Obsolete]
	LEGACY_RAW_FISH= 349,
	[Obsolete]
	LEGACY_COOKED_FISH= 350,
	[Obsolete]
	LEGACY_INK_SACK= 351,
	[Obsolete]
	LEGACY_BONE= 352,
	[Obsolete]
	LEGACY_SUGAR= 353,
	[Obsolete]
	LEGACY_CAKE= 354,
	[Obsolete]
	LEGACY_BED= 355,
	[Obsolete]
	LEGACY_DIODE= 356,
	[Obsolete]
	LEGACY_COOKIE= 357,
	/**
	 * @see org.bukkit.map.MapView
	 */
	[Obsolete]
	LEGACY_MAP= 358,
	[Obsolete]
	LEGACY_SHEARS= 359,
	[Obsolete]
	LEGACY_MELON= 360,
	[Obsolete]
	LEGACY_PUMPKIN_SEEDS= 361,
	[Obsolete]
	LEGACY_MELON_SEEDS= 362,
	[Obsolete]
	LEGACY_RAW_BEEF= 363,
	[Obsolete]
	LEGACY_COOKED_BEEF= 364,
	[Obsolete]
	LEGACY_RAW_CHICKEN= 365,
	[Obsolete]
	LEGACY_COOKED_CHICKEN= 366,
	[Obsolete]
	LEGACY_ROTTEN_FLESH= 367,
	[Obsolete]
	LEGACY_ENDER_PEARL= 368,
	[Obsolete]
	LEGACY_BLAZE_ROD= 369,
	[Obsolete]
	LEGACY_GHAST_TEAR= 370,
	[Obsolete]
	LEGACY_GOLD_NUGGET= 371,
	[Obsolete]
	LEGACY_NETHER_STALK= 372,
	[Obsolete]
	LEGACY_POTION= 373,
	[Obsolete]
	LEGACY_GLASS_BOTTLE= 374,
	[Obsolete]
	LEGACY_SPIDER_EYE= 375,
	[Obsolete]
	LEGACY_FERMENTED_SPIDER_EYE= 376,
	[Obsolete]
	LEGACY_BLAZE_POWDER= 377,
	[Obsolete]
	LEGACY_MAGMA_CREAM= 378,
	[Obsolete]
	LEGACY_BREWING_STAND_ITEM= 379,
	[Obsolete]
	LEGACY_CAULDRON_ITEM= 380,
	[Obsolete]
	LEGACY_EYE_OF_ENDER= 381,
	[Obsolete]
	LEGACY_SPECKLED_MELON= 382,
	[Obsolete]
	LEGACY_MONSTER_EGG= 383,
	[Obsolete]
	LEGACY_EXP_BOTTLE= 384,
	[Obsolete]
	LEGACY_FIREBALL= 385,
	[Obsolete]
	LEGACY_BOOK_AND_QUILL= 386,
	[Obsolete]
	LEGACY_WRITTEN_BOOK= 387,
	[Obsolete]
	LEGACY_EMERALD= 388,
	[Obsolete]
	LEGACY_ITEM_FRAME= 389,
	[Obsolete]
	LEGACY_FLOWER_POT_ITEM= 390,
	[Obsolete]
	LEGACY_CARROT_ITEM= 391,
	[Obsolete]
	LEGACY_POTATO_ITEM= 392,
	[Obsolete]
	LEGACY_BAKED_POTATO= 393,
	[Obsolete]
	LEGACY_POISONOUS_POTATO= 394,
	[Obsolete]
	LEGACY_EMPTY_MAP= 395,
	[Obsolete]
	LEGACY_GOLDEN_CARROT= 396,
	[Obsolete]
	LEGACY_SKULL_ITEM= 397,
	[Obsolete]
	LEGACY_CARROT_STICK= 398,
	[Obsolete]
	LEGACY_NETHER_STAR= 399,
	[Obsolete]
	LEGACY_PUMPKIN_PIE= 400,
	[Obsolete]
	LEGACY_FIREWORK= 401,
	[Obsolete]
	LEGACY_FIREWORK_CHARGE= 402,
	[Obsolete]
	LEGACY_ENCHANTED_BOOK= 403,
	[Obsolete]
	LEGACY_REDSTONE_COMPARATOR= 404,
	[Obsolete]
	LEGACY_NETHER_BRICK_ITEM= 405,
	[Obsolete]
	LEGACY_QUARTZ= 406,
	[Obsolete]
	LEGACY_EXPLOSIVE_MINECART= 407,
	[Obsolete]
	LEGACY_HOPPER_MINECART= 408,
	[Obsolete]
	LEGACY_PRISMARINE_SHARD= 409,
	[Obsolete]
	LEGACY_PRISMARINE_CRYSTALS= 410,
	[Obsolete]
	LEGACY_RABBIT= 411,
	[Obsolete]
	LEGACY_COOKED_RABBIT= 412,
	[Obsolete]
	LEGACY_RABBIT_STEW= 413,
	[Obsolete]
	LEGACY_RABBIT_FOOT= 414,
	[Obsolete]
	LEGACY_RABBIT_HIDE= 415,
	[Obsolete]
	LEGACY_ARMOR_STAND= 416,
	[Obsolete]
	LEGACY_IRON_BARDING= 417,
	[Obsolete]
	LEGACY_GOLD_BARDING= 418,
	[Obsolete]
	LEGACY_DIAMOND_BARDING= 419,
	[Obsolete]
	LEGACY_LEASH= 420,
	[Obsolete]
	LEGACY_NAME_TAG= 421,
	[Obsolete]
	LEGACY_COMMAND_MINECART= 422,
	[Obsolete]
	LEGACY_MUTTON= 423,
	[Obsolete]
	LEGACY_COOKED_MUTTON= 424,
	[Obsolete]
	LEGACY_BANNER= 425,
	[Obsolete]
	LEGACY_END_CRYSTAL= 426,
	[Obsolete]
	LEGACY_SPRUCE_DOOR_ITEM= 427,
	[Obsolete]
	LEGACY_BIRCH_DOOR_ITEM= 428,
	[Obsolete]
	LEGACY_JUNGLE_DOOR_ITEM= 429,
	[Obsolete]
	LEGACY_ACACIA_DOOR_ITEM= 430,
	[Obsolete]
	LEGACY_DARK_OAK_DOOR_ITEM= 431,
	[Obsolete]
	LEGACY_CHORUS_FRUIT= 432,
	[Obsolete]
	LEGACY_CHORUS_FRUIT_POPPED= 433,
	[Obsolete]
	LEGACY_BEETROOT= 434,
	[Obsolete]
	LEGACY_BEETROOT_SEEDS= 435,
	[Obsolete]
	LEGACY_BEETROOT_SOUP= 436,
	[Obsolete]
	LEGACY_DRAGONS_BREATH= 437,
	[Obsolete]
	LEGACY_SPLASH_POTION= 438,
	[Obsolete]
	LEGACY_SPECTRAL_ARROW= 439,
	[Obsolete]
	LEGACY_TIPPED_ARROW= 440,
	[Obsolete]
	LEGACY_LINGERING_POTION= 441,
	[Obsolete]
	LEGACY_SHIELD= 442,
	[Obsolete]
	LEGACY_ELYTRA= 443,
	[Obsolete]
	LEGACY_BOAT_SPRUCE= 444,
	[Obsolete]
	LEGACY_BOAT_BIRCH= 445,
	[Obsolete]
	LEGACY_BOAT_JUNGLE= 446,
	[Obsolete]
	LEGACY_BOAT_ACACIA= 447,
	[Obsolete]
	LEGACY_BOAT_DARK_OAK= 448,
	[Obsolete]
	LEGACY_TOTEM= 449,
	[Obsolete]
	LEGACY_SHULKER_SHELL= 450,
	[Obsolete]
	LEGACY_IRON_NUGGET= 452,
	[Obsolete]
	LEGACY_KNOWLEDGE_BOOK= 453,
	[Obsolete]
	LEGACY_GOLD_RECORD= 2256,
	[Obsolete]
	LEGACY_GREEN_RECORD= 2257,
	[Obsolete]
	LEGACY_RECORD_3= 2258,
	[Obsolete]
	LEGACY_RECORD_4= 2259,
	[Obsolete]
	LEGACY_RECORD_5= 2260,
	[Obsolete]
	LEGACY_RECORD_6= 2261,
	[Obsolete]
	LEGACY_RECORD_7= 2262,
	[Obsolete]
	LEGACY_RECORD_8= 2263,
	[Obsolete]
	LEGACY_RECORD_9= 2264,
	[Obsolete]
	LEGACY_RECORD_10= 2265,
	[Obsolete]
	LEGACY_RECORD_11= 2266,
	[Obsolete]
	LEGACY_RECORD_12= 2267
	//</editor-fold>
}