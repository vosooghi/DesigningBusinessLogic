# DesigningBusinessLogic
Sample of business logic implementation.

1. Transaction Script
   <ul>
   <li>https://martinfowler.com/eaaCatalog/transactionScript.html</li>
   <li>Each Command (e.g. register a user, delete a record) is implemented as a method in a class.</li>
      <li> Code maintainability demands more effort, and new requirements cause rework. </li>
   </ul>
2. Anemic Domain Model
   <ul>
   <li>https://martinfowler.com/bliki/AnemicDomainModel.html</li>
   <li>The better implementation of Transaction Script, as the input of methods is well-defined.</li>
      <li> This anti-pattern is so horrifying because it goes against the core principle of object-oriented design, which is to unite data and process in one entity. </li>
   </ul>
4. 
