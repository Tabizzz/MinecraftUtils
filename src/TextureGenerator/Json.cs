namespace TextureGenerator;

public static class Json
{
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
				-80,
				260,
				-40
			],
			"translation": [
				-1,
				-2,
				2.5
			],
			"scale": [
				0.9,
				0.9,
				0.9
			]
		},
		"thirdperson_lefthand": {
			"rotation": [
				-80,
				-280,
				40
			],
			"translation": [
				-1,
				-2,
				2.5
			],
			"scale": [
				0.9,
				0.9,
				0.9
			]
		},
		"firstperson_righthand": {
			"rotation": [
				0,
				-90,
				25
			],
			"translation": [
				1.13,
				3.2,
				1.13
			],
			"scale": [
				0.68,
				0.68,
				0.68
			]
		},
		"firstperson_lefthand": {
			"rotation": [
				0,
				90,
				-25
			],
			"translation": [
				1.13,
				3.2,
				1.13
			],
			"scale": [
				0.68,
				0.68,
				0.68
			]
		}
	}
""";
}