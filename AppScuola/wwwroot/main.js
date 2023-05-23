(function () {
    var tileUrl = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png';
    var tileAttribution = 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors, <a href="https://creativecommons.org/licenses/by-sa/2.0/">CC-BY-SA</a>';

    // Global export
    window.MappaClassi = {
        mostraMappa: function (elementId, classi) {
            var elem = document.getElementById(elementId);
            // Initialize map if needed
            elem.map = L.map(elementId);
            elem.map.addedClassi = [];
            L.tileLayer(tileUrl, { attribution: tileAttribution }).addTo(elem.map);

            var map = elem.map;

            map.addedClassi = classi.map(m => {
                return L.marker([m.latitudine, m.longitudine]).bindPopup(m.sigla).addTo(map);
            });

            // Auto-fit the view
            var classiGroup = new L.featureGroup(map.addedClassi);
            map.fitBounds(classiGroup.getBounds().pad(0.3));
        }
    }
})();
