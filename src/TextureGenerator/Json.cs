namespace TextureGenerator;

public static class Json
{

	public const string ShieldBlocking =
"""
[
	{
		"predicate": {
			"blocking": 1
		},
		"model": "item/shield_blocking"
	}
]
""";
	
	public const string ShieldDisplay = 
"""
{
	"thirdperson_righthand": {
		"rotation": [
			0, 90, 0
		],
		"translation": [
			10, 6, -4
		],
		"scale": [
			1, 1, 1
		]
	},
	"thirdperson_lefthand": {
		"rotation": [
			0, 90, 0
		],
		"translation": [
			10, 6, 12
		],
		"scale": [
			1, 1, 1
		]
	},
	"firstperson_righthand": {
		"rotation": [
			0, 180, 5
		],
		"translation": [
			-10, 2, -10
		],
		"scale": [
			1.25, 1.25, 1.25
		]
	},
	"firstperson_lefthand": {
		"rotation": [
			0, 180, 5
		],
		"translation": [
			10, 0, -10
		],
		"scale": [
			1.25, 1.25, 1.25
		]
	},
	"gui": {
		"rotation": [
			15, -25, -5
		],
		"translation": [
			2, 3, 0
		],
		"scale": [
			0.65, 0.65, 0.65
		]
	},
	"fixed": {
		"rotation": [
			0, 180, 0
		],
		"translation": [
			-4.5, 4.5, -5
		],
		"scale": [
			0.55, 0.55, 0.55
		]
	},
	"ground": {
		"rotation": [
			0, 0, 0
		],
		"translation": [
			2, 4, 2
		],
		"scale": [
			0.25, 0.25, 0.25
		]
	}
}
""";
	
	public const string BowPulling = 
"""
[
	{
		"predicate": {
			"pulling": 1
		},
		"model": "item/bow_pulling_0"
	},
	{
		"predicate": {
			"pulling": 1,
			"pull": 0.65
		},
		"model": "item/bow_pulling_1"
	},
	{
		"predicate": {
			"pulling": 1,
			"pull": 0.9
		},
		"model": "item/bow_pulling_2"
	}
]
""";

	public const string BowDisplay =
"""
{
	"thirdperson_righthand": {
		"rotation": [
			-80, 260, -40
		],
		"translation": [
			-1, -2, 2.5
		],
		"scale": [
			0.9, 0.9, 0.9
		]
	},
	"thirdperson_lefthand": {
		"rotation": [
			-80, -280, 40
		],
		"translation": [
			-1, -2, 2.5
		],
		"scale": [
			0.9, 0.9, 0.9
		]
	},
	"firstperson_righthand": {
		"rotation": [
			0, -90, 25
		],
		"translation": [
			1.13, 3.2, 1.13
		],
		"scale": [
			0.68, 0.68, 0.68
		]
	},
	"firstperson_lefthand": {
		"rotation": [
			0, 90, -25
		],
		"translation": [
			1.13, 3.2, 1.13
		],
		"scale": [
			0.68, 0.68, 0.68
		]
	}
}
""";
}