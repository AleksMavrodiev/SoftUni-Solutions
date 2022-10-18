let {assert} = require('chai');
let {addFive, subtractTen, sum} = require("../mathEnforcer");

describe("testing addFive function", () => {
    it("should return `undefined` with incorrect type", () => {
        assert.equal(addFive("Pesho"), undefined);
    });
    
    it("should sum correctly negative values", () => {
        assert.equal(addFive(-15), -10);
    });

    it("should sum correctly floating numbers", () => {
        assert.closeTo(addFive(3.14), 8.14, 0.1);
    });

    it("should sum correctly integer numbers", () => {
        assert.equal(addFive(8), 13);
    })
});

describe("testing subtract ten function", () => {
    it("should return `undefined` with incorrect type", () => {
        assert.equal(subtractTen("Pesho"), undefined);
    });
    
    it("should sum correctly negative values", () => {
        assert.equal(subtractTen(-15), -25);
    });

    it("should sum correctly floating numbers", () => {
        assert.closeTo(subtractTen(10.14), 0.14, 0.1);
    });

    it("should sum correctly integer numbers", () => {
        assert.equal(subtractTen(8), -2);
    })
});

describe("testing the function sum", () => {
    it("should return undefined when first parameter is wrong", () => {
        assert.equal(sum("Ivan", 15), undefined);
    });

    it("should return undefined when second parameter is wrong", () => {
        assert.equal(sum(15, "Gosho"), undefined);
    });

    it("should sum correctly with negative values", () => {
        assert.equal(sum(-12, -10), -22);
    });

    it("should work correctly with floating", () => {
        assert.closeTo(sum(3.14, 2.2), 5.34, 0.01);
    })

    it("should work correctly with positive numbers", () => {
        assert.equal(sum(5, 16), 21);
    })
})