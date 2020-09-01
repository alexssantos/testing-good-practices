# Good Testing Practices Samples.


## BDD (Behaviour Driven Development)
----

> BDD é uma técnica de desenvolvimento de software ágil que surge através de uma crítica de Dan North ao Test Driven Development(Desenvolvimento orientado a testes), onde ele visava otimizar o conceito de 'verificação e validação' já aplicado, e tornar mais eficiente a construção de cenários a serem testado

Sample 1: Calculator
BDD with SpecFlow using .net core.
language: c# (dotnet core 3.1)

steps: 
	1. Install SpecFlow for Visual Studio 2019 (link)[https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio]
	2. Create the Test Project 
	3. Escreva a funcionalidade e o cenário em um arquivo '.feature' como o exemplo  abaixo.

```
#language: pt-br

Funcionalidade: Calcular
	Com o objetivo de evitar erros bobos
	Como uma conta idiota
	Eu quero fazer a soma de dois numeros

@SomarDoisNumeros
Cenário: Somar dois números
	Dado que o primeiro número é 50
	E o segundo número é 70
	Quando os dois números forem somados
	Então o resultado da resposta deverá ser 70
```

	4. Generate Definitons Classe: Click right button on.feature file and 'Generate Step Definition' option.
	5. Executing your First Test: Select Test : Windows > Teste Explorer, Run All.
	6. Create Class Library Project and CalculatorClass
	7. References the CalculatorClass in Test Project and create an instance on StepDefinitoin.
	8. Binding the First Given Statement, Second Given Statement, When Statement and Then Statement.
	9. You will take install Microsoft.NET.Test.Sdk and MSTest.TestFramework packages.
	10. You will have to connect your MS Account with SpecFlow+ account.



