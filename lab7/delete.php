<?php
include "header.php"
?>
    <table class="paleBlueRows">
        <thead>
        <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Type</th>
            <th>Author</th>
        </tr>
        </thead>
        <tbody>

        </tbody>
    </table>
    <script>
        function deleteRecipe(id)
        {
            $.ajax({
                type:"GET",
                url: "api.php",
                data: {action: "deleteRecipe", id: id},
                complete: () => fetchData()
            })
        }

        function populateTable(data)
        {
            let table = $('table tbody')
            table.empty()
            for (let row of data)
            {
                let tr = $('<tr>')
                tr.append($('<td>').text(row['id']))
                tr.append($('<td>').text(row['name']))
                tr.append($('<td>').text(row['type']))
                tr.append($('<td>').text(row['author']))
                tr.click(() => deleteRecipe(row['id']))
                table.append(tr)
            }
        }

        function fetchData()
        {
            $.getJSON("api.php", {action: "getAllRecipes"}, (data) => populateTable(data))
        }

        fetchData();
    </script>
<?php

include "footer.php"
?>