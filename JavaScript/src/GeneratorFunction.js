(function () {
  function* generatorFunction() {
    console.log("1");
    yield 1;
    console.log("2");
    yield 2;
    console.log("3");
    yield 3;
    return 4;
  }

  const generator = generatorFunction();
})();
