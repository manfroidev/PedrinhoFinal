var scene, camera, renderer;
var geometry, material, mesh;


function Executar() {

    scene = new THREE.Scene();

    camera = new THREE.PerspectiveCamera(45, window.innerWidth / window.innerHeight, 1, 10000);
    camera.position.z = 900;

    geometry = new THREE.BoxGeometry(100, 100, 100);
    material = new THREE.MeshBasicMaterial({ color: 0xD1A963, wireframe: true });

    mesh = new THREE.Mesh(geometry, material);
    scene.add(mesh);

    renderer = new THREE.WebGLRenderer({ antialias: true });
    renderer.setClearColor(0x1F5A94);
    renderer.setSize(window.innerWidth, window.innerHeight);
    

    document.body.appendChild(renderer.domElement)    




    function animate() {

        requestAnimationFrame(animate);

        mesh.rotation.x += 0.01;
        mesh.rotation.y += 0.02;

        renderer.render(scene, camera);

    }
    animate();
}

window.onload = Executar;

