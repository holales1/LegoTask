# Lego task
## Indexer
This part takes care of reading the json, convert all units to the same unit(Example:Farenheit to Celsius) and insert everything on a SQLite database. To do all of this you only need to run it and thats all.
## Lego exercise form
This part has a small front end made with windows forms to show all the tasks working.

**Sort out all the vendors and the materials that the vendor offers** : For this task it is needed to click on the headers of the table that you want to sort(marked in yellow). To see the materials for each vendor it is neccessary to click on a vendor row.
![image](https://user-images.githubusercontent.com/55183635/174129506-172ac47f-c937-4b0c-a65a-370cf8562693.png)


**For each material, find the cheapest vendor and its deliver time** : To see the results of the cheapest materials for each vendor you have to click on the marked button and it will display another form.
![image](https://user-images.githubusercontent.com/55183635/174129800-4b8e3ed4-e2f0-42ba-8eb0-27bd5faf931c.png)
 
 This will show a form printing the data of each vendor with the asked fields on the task:
 ![image](https://user-images.githubusercontent.com/55183635/174130053-2f2ab1ee-5caa-4b6f-93d1-815aa57e6975.png)

**Find the best offer for the material Polymethyl Methacrylate (PMMA) and the melting point between 200C to 300C** : To see the results that i get it is neccessary to click on the marked button and it will display another form.
![image](https://user-images.githubusercontent.com/55183635/174129887-1f0cb523-8905-425c-814c-bd2efebf52ef.png)

This will show a form printing the data of the materials that fulfill he asked characteristics(name:PMMA and melting point between 200C and 300C). When the user clicks the button find best it will sort them by a simple criteria that i create myself

![image](https://user-images.githubusercontent.com/55183635/174131426-27a74f20-14e4-46d0-90a6-94aa2254cd3a.png)

**Any issues with the data model, and how can we improve it?** Colours could be stored in a separate model so we can reffer to them with a foreign key.
![image](https://user-images.githubusercontent.com/55183635/174430839-4107069f-3f76-4b47-a0df-1c57ba1c94ba.png)

Create an extra table to makea many to many relationship, so there is no duplication of the material name.
![image](https://user-images.githubusercontent.com/55183635/174430750-6fe4114a-8f99-40fa-b201-c80ce16f3317.png)

**Any other filter options you might think that might be useful?** Whether the material comes in liquid or solid state or even in powder form.
Specific storage conditions (temperature, type of packaging, size of packaging).
